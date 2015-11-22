using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Biblioteka_db
{
    public partial class FormAuthors : Form
    {
        private Autor selectedAuthor = null;

        public FormAuthors()
        {
            InitializeComponent();
        }

        public Autor SelectedAuthor 
        {
            get { return selectedAuthor; }
        }

        private void FormAuthors_Load(object sender, EventArgs e)
        {
            cbMatchInAttribute.SelectedIndex = 0;
            cbMatchAlign.SelectedIndex = 0;
            EPAuthors.SetIconAlignment(tbAuthorNameInfix, ErrorIconAlignment.MiddleLeft);
            EPAuthors.SetIconAlignment(tbBirthYearLowBound, ErrorIconAlignment.MiddleRight);
            EPAuthors.SetIconAlignment(tbBirthYearHighBound, ErrorIconAlignment.MiddleRight);
            EPAuthors.SetIconPadding(tbAuthorNameInfix, 3);
            EPAuthors.SetIconPadding(tbBirthYearLowBound, 3);
            EPAuthors.SetIconPadding(tbBirthYearHighBound, 3);
        }

        private bool isBirthYearFormatValid(string year) 
        {
            if (Regex.IsMatch(year, @"^[1-2]{1}[0-9]{3}$") == false) return false;
            return true;
        }

        private void tbAuthorNameInfix_TextChanged(object sender, EventArgs e)
        {
            string firstName = tbAuthorNameInfix.Text.Trim();
            if (firstName.Length < 2) return;
            if (firstName.Length > 71) return;
            if (Regex.IsMatch(firstName, @"^[\p{L}\-'\.]+$", RegexOptions.Singleline) == false) return;
            EPAuthors.SetError(tbAuthorNameInfix, null);
        }

        private void tbBirthYearLowBound_TextChanged(object sender, EventArgs e)
        {
            string syear = tbBirthYearLowBound.Text.Trim();
            if (isBirthYearFormatValid(syear) == false) return;
            short year=-1;
            try
            {
                year = short.Parse(syear);
            }
            catch (Exception)
            {
                return;
            }
            if (year > DateTime.Now.Year) return;
            if (year < -1) return;
            EPAuthors.SetError(tbBirthYearLowBound, null);
        }

        private void tbBirthYearHighBound_TextChanged(object sender, EventArgs e)
        {
            string syear = tbBirthYearHighBound.Text.Trim();
            if (isBirthYearFormatValid(syear) == false) return;
            short year = -1;
            try
            {
                year = short.Parse(syear);
            }
            catch (Exception)
            {
                return;
            }
            if (year > DateTime.Now.Year) return;
            if (year < -1) return;
            EPAuthors.SetError(tbBirthYearHighBound, null);
        }

        private void btnSearchAuthors_Click(object sender, EventArgs e)
        {
            string authorInfix = tbAuthorNameInfix.Text.Trim();
            string sBYLowBound = tbBirthYearLowBound.Text.Trim();
            string sBYHighBound = tbBirthYearHighBound.Text.Trim();
            short iBYLowBound = 0; // dolna granica wieku
            short iBYHighBound = 0; // gorna granica wieku
            bool BYFiltering = false; // wylaczone filtrowanie wieku
            bool lowYearFilter = false; // wylaczone dolne filtrowanie wieku
            bool highYearFilter = false; // wylaczone gorne filtrowanie wieku
            bool addNullYearFilter = true; // wlaczone filtrowanie NULL we wieku 

            /// filtrowanie szukanego ciągu
            if (authorInfix.Length < 2)
            {
                EPAuthors.SetError(tbAuthorNameInfix, "Szukany ciąg nie może być krótszy niż 2 znaki");
                return;
            }
            if (authorInfix.Length > 71)
            {
                EPAuthors.SetError(tbAuthorNameInfix, "Szukany ciąg nie może być dłuższy niż 71 znaków");
                return;
            }
            if (Regex.IsMatch(authorInfix, @"^[\p{L}\-'\.\s]+$", RegexOptions.Singleline) == false) 
            {
                EPAuthors.SetError(tbAuthorNameInfix, "Szukany ciąg zawiera niedozwolone znaki");
                return;
            }

            /// jesli filtrowanie po roku urodzenia wlaczane
            if (cbBirthYearFilter.Checked == true)
            {
                BYFiltering = true;
                if (cbBirthYearAcceptNull.Checked == true) addNullYearFilter = false; /// dodaje do wynikow rekordy z NULL w roku urodzenia

                /// jeśli filtrowanie dolne właczane
                if (sBYLowBound != "")
                {
                    lowYearFilter = true;
                    /// walidacja roku urodzenia
                    if (isBirthYearFormatValid(sBYLowBound) == false)
                    {
                        EPAuthors.SetError(tbBirthYearLowBound, "Niepoprawny format roku");
                        return;
                    }
                    try
                    {
                        iBYLowBound = short.Parse(sBYLowBound);
                    }
                    catch (Exception)
                    {
                        EPAuthors.SetError(tbBirthYearLowBound, "Niepoprawny format roku");
                        return;
                    }
                    if (iBYLowBound > DateTime.Now.Year)
                    {
                        EPAuthors.SetError(tbBirthYearLowBound, "Rok nie może być wyższy od bieżącego");
                        return;
                    }
                }
                /// jesli filtrowanie gorne wlaczone
                if (sBYHighBound != "")
                {
                    highYearFilter = true;
                    /// walidacja roku urodzenia
                    if (isBirthYearFormatValid(sBYHighBound) == false)
                    {
                        EPAuthors.SetError(tbBirthYearHighBound, "Niepoprawny format roku");
                        return;
                    }
                    try
                    {
                        iBYHighBound = short.Parse(sBYHighBound);
                    }
                    catch (Exception)
                    {
                        EPAuthors.SetError(tbBirthYearHighBound, "Niepoprawny format roku");
                        return;
                    }
                    if (iBYHighBound > DateTime.Now.Year)
                    {
                        EPAuthors.SetError(tbBirthYearHighBound, "Rok nie może być wyższy od bieżącego");
                        return;
                    }
                }
            } /// END-IF filtrowanie roku wlaczone

            /// sql-injection nie jest mozliwy podczas linkowania dynamicznego w linq
            List<Autor> results = null; // pojemnik na rezultat
            /// szukanie danych
            using (BibliotekaDataContext db = new BibliotekaDataContext()) 
            {
                IQueryable<Autor> iQuery;
                /// kompozycja zapytania dla szukania w imieniu i nazwisku autora
                if (cbMatchInAttribute.SelectedIndex == 0) // szukanie tylko w nazwisku
                {
                    if (cbMatchAlign.SelectedIndex == 0) // szukanie infix-ow
                    {
                        iQuery = db.Autors.Where(x => x.nazwisko.Contains(authorInfix));
                    }
                    else if (cbMatchAlign.SelectedIndex == 1) // szukanie prefix-ow
                    {
                        iQuery = db.Autors.Where(x => x.nazwisko.StartsWith(authorInfix));
                    }
                    else // szukanie suffix-ow
                    {
                        iQuery = db.Autors.Where(x => x.nazwisko.EndsWith(authorInfix));
                    }
                }
                else if (cbMatchInAttribute.SelectedIndex == 1) // szukanie w zlaczeniu imie_nazwisko
                {
                    if (cbMatchAlign.SelectedIndex == 0) // szukanie infix-ow
                    {
                        iQuery = db.Autors.Where(x => string.Concat(x.imie, " ", x.nazwisko).Contains(authorInfix));
                    }
                    else if (cbMatchAlign.SelectedIndex == 1) // szukanie prefix-ow
                    {
                        iQuery = db.Autors.Where(x => string.Concat(x.imie, " ", x.nazwisko).StartsWith(authorInfix));
                    }
                    else // szukanie suffix-ow
                    {
                        iQuery = db.Autors.Where(x => string.Concat(x.imie, " ", x.nazwisko).EndsWith(authorInfix));
                    }
                }
                else // szukanie tylko w imieniu
                {
                    if (cbMatchAlign.SelectedIndex == 0) // szukanie infix-ow
                    {
                        iQuery = db.Autors.Where(x => x.imie.Contains(authorInfix));
                    }
                    else if (cbMatchAlign.SelectedIndex == 1) // szukanie prefix-ow
                    {
                        iQuery = db.Autors.Where(x => x.imie.StartsWith(authorInfix));
                    }
                    else // szukanie suffix-ow
                    {
                        iQuery = db.Autors.Where(x => x.imie.EndsWith(authorInfix));
                    }
                }

                if (BYFiltering)
                {
                    /// kompozycja zapytania dla filtrowania roku
                    if (lowYearFilter && highYearFilter)
                    {
                        if (addNullYearFilter) iQuery = iQuery.Where(x => x.rokUrodzenia >= iBYLowBound && x.rokUrodzenia <= iBYHighBound && x.rokUrodzenia != null);
                        else iQuery = iQuery.Where(x => x.rokUrodzenia==null || x.rokUrodzenia >= iBYLowBound && x.rokUrodzenia <= iBYHighBound);
                    }
                    else if (lowYearFilter)
                    {
                        if (addNullYearFilter) iQuery = iQuery.Where(x => x.rokUrodzenia >= iBYLowBound && x.rokUrodzenia != null);
                        else iQuery = iQuery.Where(x => x.rokUrodzenia == null || x.rokUrodzenia >= iBYLowBound);
                    }
                    else if (highYearFilter)
                    {
                        if (addNullYearFilter) iQuery = iQuery.Where(x => x.rokUrodzenia <= iBYHighBound && x.rokUrodzenia != null);
                        else iQuery = iQuery.Where(x => x.rokUrodzenia == null || x.rokUrodzenia <= iBYHighBound);
                    }
                }

                /// --- REZULTAT
                results = iQuery.OrderBy(x => x.imie).OrderBy(x => x.nazwisko).ToList();

            }/// END-USING
            
            /// wyswietlanie wynikow
            if (results.Count > 0)
            {
                dgvAuthors.AttachNewData(results);
            }
            else
            {
                MessageBox.Show("Nie znaleziono autorów spełniających kryteria wyszukiwania.", "Brak wyników", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }/// KONIEC obslugi przycisku wyszukiwania



        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            selectedAuthor = null;
            DialogResult = DialogResult.Abort;
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            FormEditAuthor formEditAuthor = new FormEditAuthor();
            formEditAuthor.EditedAuthorID = 0;
            formEditAuthor.ShowDialog();
        }

        private void btnDeleteSelectedAuthor_Click(object sender, EventArgs e)
        {
            if (dgvAuthors.SelectedAuthor==null) 
            {
                MessageBox.Show("Nie wybrałeś autora do skasowania", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Czy na pewno chcesz usunąć tego autora?",
                "Zatwierdź", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            using (BibliotekaDataContext db = new BibliotekaDataContext()) 
            {
                db.KsiazkaAutoras.DeleteAllOnSubmit(db.KsiazkaAutoras.Where(x => x.autorID == dgvAuthors.SelectedAuthor.id).ToArray());
                db.Autors.DeleteOnSubmit(db.Autors.Where(x=>x.id==selectedAuthor.id).Single());
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception) 
                {
                    MessageBox.Show("Autor nie został usunięty.\r\nWystąpił błąd bazy danych.", "Błąd usuwania autora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            dgvAuthors.RemoveSelectedAuthor();
            MessageBox.Show("Autor " + selectedAuthor.imie.ToString() + " " + selectedAuthor.nazwisko.ToString() + " został usunięty.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditSelectedAuthor_Click(object sender, EventArgs e)
        {
            if (dgvAuthors.SelectedAuthor==null)
            {
                MessageBox.Show("Nie wybrałeś autora do edycji. ", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormEditAuthor formEditAuthor = new FormEditAuthor();
            formEditAuthor.EditedAuthorID = dgvAuthors.SelectedAuthor.id;
            if (formEditAuthor.ShowDialog() == DialogResult.OK) 
            {
                Autor editedAuthor = (new BibliotekaDataContext()).Autors.Where(x => x.id == dgvAuthors.SelectedAuthor.id).Single();
                dgvAuthors.UpdateEditedAuthor(editedAuthor);
            }
        }

        private void ChangeSelectedAuthor() 
        {
            selectedAuthor = dgvAuthors.SelectedAuthor;
            if (selectedAuthor == null)
            {
                ButtonOK.Enabled = false;
            }
            else
            {
                ButtonOK.Enabled = true;
            }
        }

        private void dgvAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeSelectedAuthor();
        }

        private void dgvAuthors_SubpageChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeSelectedAuthor();
        }

        private void dgvAuthors_RowsPerPageChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeSelectedAuthor();
        } 







    }
}
