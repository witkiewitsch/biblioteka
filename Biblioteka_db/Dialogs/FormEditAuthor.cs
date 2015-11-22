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
    public partial class FormEditAuthor : Form
    {
        private int editedAuthorID = 0;
        public FormEditAuthor()
        {
            InitializeComponent();
            EPNewAuthor.SetIconAlignment(tbFirstname, ErrorIconAlignment.MiddleLeft);
            EPNewAuthor.SetIconAlignment(tbSurname, ErrorIconAlignment.MiddleLeft);
            EPNewAuthor.SetIconAlignment(tbBirthYear, ErrorIconAlignment.MiddleLeft);
            EPNewAuthor.SetIconPadding(tbFirstname, 3);
            EPNewAuthor.SetIconPadding(tbSurname, 3);
            EPNewAuthor.SetIconPadding(tbBirthYear, 3);
        }

        public int EditedAuthorID 
        {
            get { return editedAuthorID; }
            set { editedAuthorID = value; }
        }

        private void tbFirstname_TextChanged(object sender, EventArgs e)
        {
            string firstName = tbFirstname.Text;
            if (firstName.Length < 2)
            {
                return;
            }
            if (firstName.Length > 20)
            {
                return;
            }
            if (Regex.IsMatch(firstName, @"^[\p{Lu}]{1}[\p{L}\'\-\s]+[\p{L}]+\.*?$", RegexOptions.Singleline) == false
                || Regex.IsMatch(firstName, @"(('\-)|('')|(\-\-)|(\-'))") == true)
            {
                return;
            }
            EPNewAuthor.SetError(tbFirstname, null);
        }

        private void tbSurname_TextChanged(object sender, EventArgs e)
        {
            string surName = tbSurname.Text;
            if (surName.Length < 2)
            {
                return;
            }
            if (surName.Length > 50)
            {
                return;
            }
            if (Regex.IsMatch(surName, @"^[\p{Lu}]{1}[\p{L}\'\-\s]+[\p{L}]+$") == false
                || Regex.IsMatch(surName, @"(('\-)|('')|(\-\-)|(\-'))") == true)
            {
                return;
            }
            EPNewAuthor.SetError(tbSurname, null);
        }

        private void tbBirthYear_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbBirthYear.Text, @"^[1-2]{1}[0-9]{3}$", RegexOptions.Singleline) == false)
            {
                return;
            }
            int birthYear = 0;
            try
            {
                birthYear = int.Parse(tbBirthYear.Text);
            }
            catch (Exception)
            {
                return;
            }
            if (birthYear > DateTime.Now.Year)
            {
                return;
            }
            EPNewAuthor.SetError(tbBirthYear, null);
        }




        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// przycisk dodajacy/zapisujacy edycje
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstname.Text.Trim();
            if (firstName.Length < 2)
            {
                EPNewAuthor.SetError(tbFirstname, "Imię musi zawierać nie mniej niż 2 znaki");
                return;
            }
            if (firstName.Length > 20)
            {
                EPNewAuthor.SetError(tbFirstname, "Imie nie może zawierać więcej niż 50 znaków");
                return;
            }
            if (Regex.IsMatch(firstName, @"^[\p{Lu}]{1}[\p{L}\'\-\s]+[\p{L}]+\.*?$", RegexOptions.Singleline) == false
                || Regex.IsMatch(firstName, @"(('\-)|('')|(\-\-)|(\-'))") == true)
            {
                EPNewAuthor.SetError(tbFirstname, "Podany wyraz nie spełnił kryteriów poprawności imienia");
                return;
            }

            string surName = tbSurname.Text.Trim();
            if (surName.Length < 2)
            {
                EPNewAuthor.SetError(tbSurname, "Imię musi zawierać nie mniej niż 2 znaki");
                return;
            }
            if (surName.Length > 50)
            {
                EPNewAuthor.SetError(tbSurname, "Imie nie może zawierać więcej niż 50 znaków");
                return;
            }
            if (Regex.IsMatch(surName, @"^[\p{Lu}]{1}[\p{L}\'\-\s]+[\p{L}]+$") == false
                || Regex.IsMatch(surName, @"(('\-)|('')|(\-\-)|(\-'))") == true)
            {
                EPNewAuthor.SetError(tbSurname, "Podany wyraz nie spełnił kryteriów poprawności imienia");
                return;
            }

            short birthYear = 0;
            if (tbBirthYear.Text.Trim() != "")
            {
                if (Regex.IsMatch(tbBirthYear.Text.Trim(), @"^[1-2]{1}[0-9]{3}$", RegexOptions.Singleline) == false)
                {
                    EPNewAuthor.SetError(tbBirthYear, "Niepoprawny format roku");
                    return;
                }
                try
                {
                    birthYear = short.Parse(tbBirthYear.Text.Trim());
                }
                catch (Exception)
                {
                    EPNewAuthor.SetError(tbBirthYear, "Niepoprawny format roku");
                    return;
                }
                if (birthYear > DateTime.Now.Year)
                {
                    EPNewAuthor.SetError(tbBirthYear, "Narodziny autora nie mogą mieć miejsca w przyszłości.");
                    return;
                }
            }
            if (editedAuthorID == 0)
            {
                using (BibliotekaDataContext db = new BibliotekaDataContext())
                {
                    if (birthYear > 0 && db.Autors.Count(x => x.imie == firstName && x.nazwisko == surName && x.rokUrodzenia != null && x.rokUrodzenia == birthYear) > 0)
                    {
                        MessageBox.Show("Autor, którego próbujesz dodać, istnieje już w bazie danych", "Autor już istnieje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (birthYear == 0 && db.Autors.Count(x => x.imie == firstName && x.nazwisko == surName && x.rokUrodzenia == null) > 0)
                    {
                        MessageBox.Show("Autor, którego próbujesz dodać, istnieje już w bazie danych", "Autor już istnieje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (birthYear == 0)
                    {
                        db.Autors.InsertOnSubmit(new Autor()
                        {
                            imie = firstName,
                            nazwisko = surName,
                            rokUrodzenia = null
                        });
                    }
                    else
                    {
                        db.Autors.InsertOnSubmit(new Autor()
                        {
                            imie = firstName,
                            nazwisko = surName,
                            rokUrodzenia = birthYear
                        });
                    }
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wystąpił problem podczas dodawania autora do bazy danych", "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                tbFirstname.Text = "";
                tbSurname.Text = "";
                tbBirthYear.Text = "";
                if (MessageBox.Show("Nowy autor został poprawnie zapisany w bazie danych.\r\nCzy chcesz kontynuować dodawanie?", "Operacja zakończona", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
                {
                    DialogResult = DialogResult.OK;
                }
            }
            else /// tutaj zaczyna sie tryb edycji
            {
                using (BibliotekaDataContext db = new BibliotekaDataContext()) 
                {
                    Autor editedAuthor = null;
                    try
                    {
                        editedAuthor = db.Autors.Where(x => x.id == editedAuthorID).Single();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("W bazie danych nie ma autora, którego próbujesz edytować.", "Wystąpił błąd formularza.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (editedAuthor.imie == firstName && editedAuthor.nazwisko == surName && ((editedAuthor.rokUrodzenia == null && birthYear == 0) || (editedAuthor.rokUrodzenia == birthYear))) 
                    {
                        MessageBox.Show("Nie dokonałeś żadnych zmian. Operacja nie będzie kontynuowana.", "Brak zmian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    editedAuthor.imie = firstName;
                    editedAuthor.nazwisko = surName;
                    if (birthYear == 0) editedAuthor.rokUrodzenia = null;
                    else editedAuthor.rokUrodzenia = birthYear;

                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wystąpił problem podczas modyfikowania autora w bazie danych", "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    MessageBox.Show("Autor został poprawnie zmodyfikowany w bazie danych.", "Operacja zakończona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
            } // koniec wyboru pomiedzy dodawaniem i edycja w czesci aktywnej
        } // koniec obslugi przycisku dodajaco-edytujacego

        private void FormEditAuthor_Load(object sender, EventArgs e)
        {
            if (editedAuthorID == 0)
            {
                tbFirstname.Text = "";
                tbSurname.Text = "";
                tbBirthYear.Text = "";
                return;
            }
            Autor author = (new BibliotekaDataContext()).Autors.Where(x => x.id == editedAuthorID).Single();
            if (author == null) 
            {
                tbFirstname.Text = "";
                tbSurname.Text = "";
                tbBirthYear.Text = "";
                return;
            }

            tbFirstname.Text = author.imie;
            tbSurname.Text = author.nazwisko;
            if (author.rokUrodzenia == null)
            {
                tbBirthYear.Text = "";
            }
            else
            {
                tbBirthYear.Text = author.rokUrodzenia.ToString();
            }
            ButtonAdd.Text = "Zapisz";
            this.Text = "Edycja autora";
        }



    }
}
