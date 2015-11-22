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


// @ wersja kompletna, niesprawdzona, nierefaktoryzowana

namespace Biblioteka_db
{
    public partial class FormCategories : Form
    {
        private Kategoria selectedCategory = null;
        private string selectedCategoryKey = null;
        private string sqlExceptionMessage = null;

        public FormCategories()
        {
            InitializeComponent();
            EPCategories.SetIconAlignment(labSelectedCategoryName, ErrorIconAlignment.MiddleLeft);
            EPCategories.SetIconAlignment(tbNewCategoryName, ErrorIconAlignment.MiddleLeft);
            EPCategories.SetIconAlignment(cbSubCatsDecision, ErrorIconAlignment.MiddleLeft);
            EPCategories.SetIconAlignment(tbNewName, ErrorIconAlignment.MiddleLeft);
            EPCategories.SetIconPadding(labSelectedCategoryName, 3);
            EPCategories.SetIconPadding(tbNewCategoryName, 3);
            EPCategories.SetIconPadding(cbSubCatsDecision, 3);
            EPCategories.SetIconPadding(tbNewName, 3);
        }

        public Kategoria SelectedCategory
        {
            get { return selectedCategory; }
        }
        public int SelectedCategoryID
        {
            get
            {
                if (selectedCategory == null) return 0;
                return selectedCategory.id;
            }
        }
        public string SelectedCategoryName
        {
            get
            {
                if (selectedCategory == null) return selectedCategoryKey;
                return selectedCategory.nazwa;
            }
        }
        public int SelectedCategoryParentID
        {
            get
            {
                if (selectedCategory == null) return 0;
                if (selectedCategory.kategoriaNadrzednaID == null) return 0;
                return (int)selectedCategory.kategoriaNadrzednaID;
            }
        }

        private void LoadCategoryTreeLevel(TreeNodeCollection CurrentRootTreeNodeSubs, int CurrentRootCID=0) 
        {
            List<Kategoria> subCategories = null;
            using (BibliotekaDataContext db = new BibliotekaDataContext()) 
            {
                if(CurrentRootCID==0) subCategories = db.Kategorias.Where(x => x.kategoriaNadrzednaID == null).OrderBy(x => x.id).ToList();
                else subCategories = db.Kategorias.Where(x => x.kategoriaNadrzednaID == CurrentRootCID).OrderBy(x => x.id).ToList();
            }
            if (subCategories.Count == 0) return;
            foreach (Kategoria child in subCategories) 
            {
                TreeNode tn = CurrentRootTreeNodeSubs.Add(child.nazwa, child.nazwa);
                LoadCategoryTreeLevel(tn.Nodes, child.id);
            }
        }

        private void LoadCategories() 
        {
            SuspendLayout();
            tvCategories.Nodes.Add("0", "Książki bez kategorii").ForeColor = Color.FromArgb(0, 0, 255);
            TreeNode tn = tvCategories.Nodes.Add("1", "Wszystkie kategorie");
            tn.ForeColor = Color.FromArgb(0, 0, 255);
            LoadCategoryTreeLevel(tn.Nodes, 0);
            ResumeLayout();
            tn.Expand();
        }


        private void FormCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
            cbSubCatsDecision.SelectedIndex = 0;
        }

        private void tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "0") 
            {
                selectedCategory = null;
                labSelectedCategoryName.Text = "Książki bez kategorii";
                labSelectedCategoryName.ForeColor = Color.FromArgb(0, 0, 255);
            }
            else if (e.Node.Name == "1")
            {
                selectedCategory = null;
                labSelectedCategoryName.Text = "Wszystkie kategorie";
                labSelectedCategoryName.ForeColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                selectedCategory = (new BibliotekaDataContext()).Kategorias.Where(x => x.nazwa == e.Node.Text).Single();
                labSelectedCategoryName.Text = selectedCategory.nazwa;
                labSelectedCategoryName.ForeColor = Color.FromArgb(0, 0, 0);
            }
            EPCategories.SetError(labSelectedCategoryName, null);
            EPCategories.SetError(cbSubCatsDecision, null);
        }

        private void tbNewCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (tbNewCategoryName.Text.Length <= 50 &&
                tbNewCategoryName.Text.Length >= 3 &&
                tvCategories.Nodes.ContainsKey(tbNewCategoryName.Text) == false &&
                Regex.IsMatch(tbNewCategoryName.Text, @"^[A-ZĘÓĄŚŁŻŹĆŃ]{1}[A-Za-zęóąśłżźćńĘÓĄŚŁŻŹĆŃ0-9\s]*[A-Za-zęóąśłżźćńĘÓĄŚŁŻŹĆŃ0-9]+$", RegexOptions.Singleline) == true
                )
                EPCategories.SetError(tbNewCategoryName, null);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            string newCategoryName = tbNewCategoryName.Text.Trim();

            if (selectedCategory == null)
            {
                EPCategories.SetError(labSelectedCategoryName, "Wybierz kategorię nadrzędną");
                return;
            }

            if (newCategoryName.Length > 50) 
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii nie może być dłuższa niż 50 znaków");
                return;
            }
            if (newCategoryName.Length < 3) 
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii nie może być krótsza niż 3 znaki");
                return;
            }
            if (Regex.IsMatch(newCategoryName, @"^[A-ZĘÓĄŚŁŻŹĆŃ]{1}") == false)
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii musi rozpoczynać się z wielkiej litery");
                return;
            }
            if (Regex.IsMatch(newCategoryName, @"^[A-Za-zęóąśłżźćńĘÓĄŚŁŻŹĆŃ0-9\s]*[A-ZęóąśłżźćńĘÓĄŚŁŻŹĆŃa-z0-9]+$", RegexOptions.Singleline) == false)
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii nie może zawierać innych znaków niż alfanumeryczne oraz spacje. Spacja nie może wystąpić na końcu");
                return;
            }

            using (BibliotekaDataContext db = new BibliotekaDataContext())
            {
                if (db.Kategorias.Count(x => x.nazwa == newCategoryName) > 0)
                {
                    EPCategories.SetError(tbNewCategoryName, "Kategoria o podanej nazwie już istnieje");
                    return;
                }

                db.Kategorias.InsertOnSubmit(new Kategoria()
                {
                    nazwa = newCategoryName,
                    kategoriaNadrzednaID = selectedCategory.id
                });
                try
                {
                    db.SubmitChanges();
                }
                catch (System.Data.SqlClient.SqlException sqlExp)
                {
                    sqlExceptionMessage = sqlExp.Message;
                    MessageBox.Show("Wystąpił błąd związany z bazą danych.", "Błąd dodawania kategorii", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tvCategories.SelectedNode.Nodes.Add(newCategoryName,newCategoryName);
        }

        private void btnAddNewRootCategory_Click(object sender, EventArgs e)
        {
            string newRootCategoryName = tbNewCategoryName.Text.Trim();
            EPCategories.SetError(labHeaderNewCategoryName, null);
            if (newRootCategoryName.Length > 50)
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii nie może być dłuższa niż 50 znaków");
                return;
            }
            if (newRootCategoryName.Length < 3)
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii nie może być krótsza niż 3 znaki");
                return;
            }

            if (Regex.IsMatch(newRootCategoryName, @"^[A-ZĘÓĄŚŁŻŹĆŃ]{1}") == false)
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii musi rozpoczynać się z wielkiej litery");
                return;
            }
            if (Regex.IsMatch(newRootCategoryName, @"^[A-Za-zęóąśłżźćńĘÓĄŚŁŻŹĆŃ0-9\s]*[A-ZęóąśłżźćńĘÓĄŚŁŻŹĆŃa-z0-9]+$", RegexOptions.Singleline) == false)
            {
                EPCategories.SetError(tbNewCategoryName, "Nazwa kategorii nie może zawierać innych znaków niż alfanumeryczne oraz spacje. Spacja nie może wystąpić na końcu");
                return;
            }

            using (BibliotekaDataContext db = new BibliotekaDataContext())
            {
                if (db.Kategorias.Count(x => x.nazwa == newRootCategoryName) > 0)
                {
                    EPCategories.SetError(tbNewCategoryName, "Kategoria o podanej nazwie już istnieje");
                    return;
                }

                db.Kategorias.InsertOnSubmit(new Kategoria()
                {
                    nazwa = newRootCategoryName,
                    kategoriaNadrzednaID = null
                });
                try
                {
                    db.SubmitChanges();
                }
                catch (System.Data.SqlClient.SqlException sqlExp)
                {
                    sqlExceptionMessage = sqlExp.Message;
                    MessageBox.Show("Wystąpił błąd związany z bazą danych.", "Błąd dodawania kategorii", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tvCategories.Nodes.Add(newRootCategoryName, newRootCategoryName);
        }


        private void btnDeleteSelectedCategory_Click(object sender, EventArgs e)
        {
            if (selectedCategory==null)
            {
                if (tvCategories.SelectedNode.Name == "0" || tvCategories.SelectedNode.Name == "1")
                {
                    EPCategories.SetError(labSelectedCategoryName, "Kategorii wyróżnionych niebieskim kolorem nie można usunąć");
                }
                else
                {
                    EPCategories.SetError(labSelectedCategoryName, "Wybierz kategorię do usunięcia");
                }
                return;
            }

            string selectedCategoryName = labSelectedCategoryName.Text;

            if ((new BibliotekaDataContext()).Kategorias.Count(x => x.nazwa == selectedCategoryName) == 0) 
            {
                MessageBox.Show("Prawdopodobnie formularz wymaga odświeżenia. Nie ma kategorii, którą próbujesz usunąć.",
                    "Błąd usuwania kategorii", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool deleteSubs = cbSubCatsDecision.SelectedIndex == 0 ? false : true;
            bool makeSubsTLC = false;

            if (selectedCategory.kategoriaNadrzednaID == null && deleteSubs == false) { }
            {
                if ((new BibliotekaDataContext()).Kategorias.Count(x => x.kategoriaNadrzednaID == selectedCategory.id) == 0)
                {
                    makeSubsTLC = true;
                }
                else if (MessageBox.Show(
                    "Wybrana kategoria nie posiada kategorii nadrzędnej. Wybrałeś opcję przenoszącą podkategorię do kategorii nadrzędnej.\r\nKontynuacja będzie oznaczała zamianę podkategorii w kategorie najwyższego poziomu.\r\n\r\nCzy chcesz przerwać operację?",
                    "Sytuacja wyjątkowa podczas usuwania kategorii",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.No)
                {
                    makeSubsTLC = true; // Czy uczynic podkategorie korzeniami
                }
                else
                {
                    EPCategories.SetError(cbSubCatsDecision, "Wybrana kategoria nie posiada kategorii nadrzędnej");
                    return;
                }
            }


            /* +++ Operacje na bazie danych */
            using (BibliotekaDataContext db = new BibliotekaDataContext())
            {
                Kategoria newSelectedCategory = selectedCategory.Kategoria1;

                // pobieranie identyfikatorow podkategorii
                List<int> subsIDs = db.Kategorias.Where(x => x.kategoriaNadrzednaID == selectedCategory.id).Select(x => x.id).ToList();

                if (deleteSubs)
                {
                    // +++ uzupelniam poddrzewo kategorii
                    int treeElementsCount = -1;
                    while (treeElementsCount != subsIDs.Count)
                    {
                        treeElementsCount = subsIDs.Count;
                        subsIDs = db.Kategorias.Where(x => subsIDs.Contains(x.id) || subsIDs.Contains((int)x.kategoriaNadrzednaID)).Select(x => x.id).Distinct().ToList();
                    }
                    subsIDs.Add(selectedCategory.id);
                    // --- poddrzewo uzupelnione
                    // kasowanie powiazan kategorii z ksiazkami
                    db.KategoriaKsiazkis.DeleteAllOnSubmit(db.KategoriaKsiazkis.Where(x => subsIDs.Contains(x.kategoriaID)).ToArray());
                    // kasowanie calego drzewa podkategorii
                    db.Kategorias.DeleteAllOnSubmit(db.Kategorias.Where(x => subsIDs.Contains(x.id)).ToArray());
                }
                else if (makeSubsTLC) 
                {
                    db.KategoriaKsiazkis.DeleteAllOnSubmit(db.KategoriaKsiazkis.Where(x => x.kategoriaID == selectedCategory.id).ToArray());
                    List<Kategoria> scl = db.Kategorias.Where(x => x.kategoriaNadrzednaID == selectedCategory.id).ToList();
                    foreach (Kategoria sc in scl)
                    {
                        sc.kategoriaNadrzednaID = null;
                    }
                    db.Kategorias.DeleteOnSubmit(db.Kategorias.Where(x => x.id == selectedCategory.id).Single());
                }
                else
                {
                    db.KategoriaKsiazkis.DeleteAllOnSubmit(db.KategoriaKsiazkis.Where(x => x.kategoriaID == selectedCategory.id).ToArray());
                    List<Kategoria> scl = db.Kategorias.Where(x => x.kategoriaNadrzednaID == selectedCategory.id).ToList();
                    foreach (Kategoria sc in scl)
                    {
                        sc.kategoriaNadrzednaID = selectedCategory.kategoriaNadrzednaID;
                    }
                    db.Kategorias.DeleteOnSubmit(db.Kategorias.Where(x => x.id == selectedCategory.id).Single());
                }

                try
                {
                    db.SubmitChanges();
                }
                catch (System.Data.SqlClient.SqlException sqlExp)
                {
                    sqlExceptionMessage = sqlExp.Message;
                    MessageBox.Show("Wystąpił błąd związany z bazą danych.", "Błąd usuwania kategorii", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                selectedCategory = newSelectedCategory;
            }
            /* --- Operacje na bazie danych */


            /* +++ Aktualizacja TreeView */
            SuspendLayout();
            TreeNode newSelectedNode = tvCategories.SelectedNode.Parent;
            if (deleteSubs == true)
            {
                tvCategories.SelectedNode.Remove();
            }
            else 
            {
                foreach (TreeNode tn in tvCategories.SelectedNode.Nodes) 
                {
                    tvCategories.SelectedNode.Parent.Nodes.Add(tn.Name, tn.Text);
                }
                tvCategories.SelectedNode.Nodes.Clear();
                tvCategories.SelectedNode.Remove();
            }
            tvCategories.SelectedNode = newSelectedNode;
            ResumeLayout();
            /* --- Aktualizacja TreeView */

            labSelectedCategoryName.Text = selectedCategory == null ? (selectedCategoryKey == null ? "" : selectedCategoryKey) : selectedCategory.nazwa;
        }

        private void btnRenameSelectedCategory_Click(object sender, EventArgs e)
        {
            string newName = tbNewName.Text.Trim();

            if (selectedCategory == null)
            {
                EPCategories.SetError(labSelectedCategoryName, "Wybierz kategorię, której nazwę chcesz zmienić");
                return;
            }

            if (newName.Length > 50)
            {
                EPCategories.SetError(tbNewName, "Nazwa kategorii nie może być dłuższa niż 50 znaków");
                return;
            }
            if (newName.Length < 3)
            {
                EPCategories.SetError(tbNewName, "Nazwa kategorii nie może być krótsza niż 3 znaki");
                return;
            }
            if (Regex.IsMatch(newName, @"^[A-ZĘÓĄŚŁŻŹĆŃ]{1}") == false) 
            {
                EPCategories.SetError(tbNewName, "Nazwa kategorii musi rozpoczynać się z wielkiej litery");
                return;
            }
            if (Regex.IsMatch(newName, @"^[A-Za-zęóąśłżźćńĘÓĄŚŁŻŹĆŃ0-9\s]*[A-ZęóąśłżźćńĘÓĄŚŁŻŹĆŃa-z0-9]+$", RegexOptions.Singleline) == false) 
            {
                EPCategories.SetError(tbNewName, "Nazwa kategorii nie może zawierać innych znaków niż alfanumeryczne oraz spacje. Spacja nie może wystąpić na końcu");
                return;
            }
            using (BibliotekaDataContext db = new BibliotekaDataContext())
            {
                if (db.Kategorias.Count(x => x.nazwa == newName) > 0)
                {
                    EPCategories.SetError(tbNewName, "Kategoria o podanej nazwie już istnieje");
                    return;
                }

                db.Kategorias.Where(x => x.id == selectedCategory.id).Single().nazwa = newName;
                try
                {
                    db.SubmitChanges();
                }
                catch (System.Data.SqlClient.SqlException sqlExp)
                {
                    sqlExceptionMessage = sqlExp.Message;
                    MessageBox.Show("Wystąpił błąd związany z bazą danych.", "Błąd zmiany nazwy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tvCategories.SelectedNode.Text = newName;
            tvCategories.SelectedNode.Name = newName;
            labSelectedCategoryName.Text = newName;
        }

        private void tbNewName_TextChanged(object sender, EventArgs e)
        {
            if (tbNewName.Text.Length <= 50 &&
                tbNewName.Text.Length >= 3 &&
                tvCategories.Nodes.ContainsKey(tbNewName.Text) == false &&
                Regex.IsMatch(tbNewName.Text, @"[A-ZĘÓĄŚŁŻŹĆŃ]{1}[A-Za-zęóąśłżźćńĘÓĄŚŁŻŹĆŃ0-9\s]*[A-Za-zęóąśłżźćńĘÓĄŚŁŻŹĆŃ0-9]+$", RegexOptions.Singleline) == true
                )
                EPCategories.SetError(tbNewName, null);
        }

    }
}
