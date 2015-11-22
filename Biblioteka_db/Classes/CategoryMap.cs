using System;
//using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka_db.Classes
{
    class CategoryMap
    {
        private static CategoryMap instance = null;
        public static CategoryMap getInstance()
        {
            if (instance == null) instance = new CategoryMap();
            return instance;
        }
        private List<Kategoria> categories = null;
        private string lastException = null;

        public string LastException 
        {
            get {
                string returnString = lastException;
                lastException=null;
                return returnString;
            }
        }

        public int Count 
        {
            get {
                return categories.Count;
            }
        }

        private CategoryMap()
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            BibliotekaDataContext db = new BibliotekaDataContext();
            categories = new List<Kategoria>();
            foreach (Kategoria cat in db.Kategorias) 
            {
                categories.Add(cat);
            }
        }

        public bool Add(string categoryName, int parentId, int ID=-1)
        {
            BibliotekaDataContext db = new BibliotekaDataContext();
            if (categories.Exists(x => x.nazwa == categoryName) == true) return false;

            if (ID <= 0)
            {
                db.Kategorias.InsertOnSubmit(new Kategoria() { nazwa = categoryName, kategoriaNadrzednaID = parentId });
            }
            else 
            {
                db.Kategorias.InsertOnSubmit(new Kategoria() { nazwa = categoryName, kategoriaNadrzednaID = parentId, id=ID });
            }
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException SqlExp) 
            {
                lastException = SqlExp.Message;
                return false;
            }
            Kategoria cat = db.Kategorias.Where(x => x.nazwa == categoryName).Single();
            categories.Add(cat);

            return true;
        }

        public bool Remove(int categoryID)
        {
            if (categories.Exists(x=>x.id==categoryID) == false) return false;

            Kategoria delCat = categories.Where(x => x.id == categoryID).Single();

            BibliotekaDataContext db = new BibliotekaDataContext();
            db.Kategorias.DeleteOnSubmit(delCat);
            try
            {
                db.SubmitChanges();
            }
            catch(System.Data.SqlClient.SqlException SqlExp) 
            {
                lastException = SqlExp.Message;
                return false;
            }
            categories.Remove(delCat);

            return true;
        }
        public bool Remove(string categoryName)
        {
            if (categories.Exists(x => x.nazwa == categoryName) == false) return false;

            Kategoria delCat = categories.Where(x => x.nazwa == categoryName).Single();

            BibliotekaDataContext db = new BibliotekaDataContext();
            db.Kategorias.DeleteOnSubmit(delCat);
            try
            {
                db.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException SqlExp)
            {
                lastException = SqlExp.Message;
                return false;
            }
            categories.Remove(delCat);

            return true;
        }

        public bool Exists(string categoryName) 
        {
            return categories.Exists(x => x.nazwa == categoryName);
        }

        public Kategoria GetCategory(string categoryName)
        {
            if (categories.Exists(x => x.nazwa == categoryName) == false) return null;
            return categories.FirstOrDefault(x => x.nazwa == categoryName);
        }
        public Kategoria GetCategory(int categoryID)
        {
            if (categories.Exists(x => x.id == categoryID) == false) return null;
            return categories.FirstOrDefault(x => x.id == categoryID);
        }

        public Kategoria this[int index]
        {
            get
            {
                if (index < 0) return null;
                if (index < categories.Count) return categories[index];
                return null;
            }
        }
    }
}
