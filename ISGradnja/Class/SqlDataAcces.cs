using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows;

namespace ISGradnja.Class
{
    class SqlDataAcces
    {

        public static bool AddRadnik(Radnik radnik)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "insert into radnici(ime_prezime,adresa,broj_telefona,jmbg,delatnost,gradiliste)values('" + radnik.ImePrezime + "','" + radnik.Adresa + "','" + radnik.BrojTelefona + "','" + radnik.JMBG + "','" + radnik.Delatnost + "','" + radnik.Gradiliste + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool AddProjekat(Class.Projekti projekti)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "insert into projketi(naziv,investitor,adresa,tip,spratnost,pocetak_datum,rok_datum,dokument1,dokument2,dokument3)values('" + projekti.Naziv + "','" + projekti.Investitor + "','" + projekti.Adresa + "','" + projekti.Tip + "','" + projekti.Spratnost + "','" + projekti.PocetakDatum + "','" + projekti.RokDatum + "','" + projekti.Dokument1 + "','" + projekti.Dokument2 + "','" + projekti.Dokument3 + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool UpdataRadnik(Radnik radnik, string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "UPDATE radnici SET ime_prezime = '" + radnik.ImePrezime + "',adresa = '" + radnik.Adresa + "',broj_telefona='" + radnik.BrojTelefona + "' ,jmbg='" + radnik.JMBG + "' ,delatnost= '" + radnik.Delatnost + "',gradiliste='" + radnik.Gradiliste + "' where id = (" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool UpdataMagacin(Class.Magacin magacin, string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "UPDATE magacin SET naziv = '" + magacin.Naziv + "',merna_jedinica = '" + magacin.MernaJedinica + "',kolicina='" + magacin.Kolicina + "' ,dostupno='" + magacin.Dostupno + "' where id = (" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool DelRadnik(string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "DELETE FROM radnici WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool DelDelatnosti(string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "DELETE FROM radnik_delatnost WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool DelTipObjekta (string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "DELETE FROM tip_objekta WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool DelMagacinRaspodela(string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "DELETE FROM magacin_raspodela WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool DelMagacin(string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "DELETE FROM magacin WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool DelProjekat(string id)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "DELETE FROM projketi WHERE id=(" + id + ")";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool AddDelatnost(Delatnosti delatnosti)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "insert into radnik_delatnost(naziv)values('" + delatnosti.Naziv + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool AddMagacin(Magacin magacin)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "insert into magacin(naziv,merna_jedinica,kolicina,dostupno)values('" + magacin.Naziv + "','" + magacin.MernaJedinica + "','" + magacin.Kolicina + "','" + magacin.Dostupno + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool AddMagacinRaspodela(MagacinRaspodela magacin)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "insert into magacin_raspodela(naziv,gradiliste,kolicina)values('" + magacin.Naziv + "','" + magacin.Gradiliste + "','" + magacin.Kolicina + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static bool AddTipObjekta(TipObjekta tipObjekta)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
                String query = "insert into tip_objekta(naziv)values('" + tipObjekta.Naziv + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }

        }

        public static DataSet GetAllRadnik()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM radnici";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                return DS;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataSet GetAllTipObjektaDS()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM tip_objekta";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                return DS;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataSet GetAllDelatnostiDS()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM radnik_delatnost";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                return DS;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataSet GetAllProjekti()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM projketi";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                return DS;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataSet GetAllMagacin()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM magacin";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                return DS;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataSet GetAllMagacinRaspodela()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM magacin_raspodela";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                return DS;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static Radnik GetRadnik(string id)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM radnici WHERE id=(" + id + ")";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Radnik radnik = new Radnik()
                {
                    ImePrezime = DS.Tables[0].Rows[0]["ime_prezime"].ToString(),
                    Adresa = DS.Tables[0].Rows[0]["adresa"].ToString(),
                    BrojTelefona = DS.Tables[0].Rows[0]["broj_telefona"].ToString(),
                    JMBG = DS.Tables[0].Rows[0]["jmbg"].ToString(),
                    Delatnost = DS.Tables[0].Rows[0]["delatnost"].ToString(),
                    Gradiliste = DS.Tables[0].Rows[0]["gradiliste"].ToString()
                };

                return radnik;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static Class.Projekti GetProjekat(string id)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM projketi WHERE id=(" + id + ")";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Class.Projekti radnik = new Projekti()
                {
                    Naziv = DS.Tables[0].Rows[0]["naziv"].ToString(),
                    Investitor = DS.Tables[0].Rows[0]["investitor"].ToString(),
                    Adresa = DS.Tables[0].Rows[0]["adresa"].ToString(),
                    Tip = DS.Tables[0].Rows[0]["tip"].ToString(),
                    Spratnost = DS.Tables[0].Rows[0]["spratnost"].ToString(),
                    PocetakDatum = DS.Tables[0].Rows[0]["pocetak_datum"].ToString(),
                    RokDatum = DS.Tables[0].Rows[0]["rok_datum"].ToString(),
                    Dokument1 = DS.Tables[0].Rows[0]["dokument1"].ToString(),
                    Dokument2 = DS.Tables[0].Rows[0]["dokument2"].ToString(),
                    Dokument3 = DS.Tables[0].Rows[0]["dokument3"].ToString()
                };

                return radnik;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static Class.Magacin GetMagacin(string id)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM magacin WHERE id=(" + id + ")";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Class.Magacin magacin = new Class.Magacin()
                {
                    Naziv = DS.Tables[0].Rows[0]["naziv"].ToString(),
                    MernaJedinica = DS.Tables[0].Rows[0]["merna_jedinica"].ToString(),
                    Kolicina = int.Parse(DS.Tables[0].Rows[0]["kolicina"].ToString()),
                    Dostupno = int.Parse(DS.Tables[0].Rows[0]["dostupno"].ToString())
                };
                //(int)DS.Tables[0].Rows[0]["dostupno"]
                return magacin;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static Class.Magacin GetMagacinByName(string naziv)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM magacin WHERE naziv = ('" + naziv + "')";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Class.Magacin magacin = new Class.Magacin()
                {
                    Naziv = DS.Tables[0].Rows[0]["naziv"].ToString(),
                    MernaJedinica = DS.Tables[0].Rows[0]["merna_jedinica"].ToString(),
                    Kolicina = int.Parse(DS.Tables[0].Rows[0]["kolicina"].ToString()),
                    Dostupno = int.Parse(DS.Tables[0].Rows[0]["dostupno"].ToString())
                };
                //(int)DS.Tables[0].Rows[0]["dostupno"]
                return magacin;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static string GetMagacinIDByName(string id)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM magacin WHERE naziv = ('" + id + "')";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                
                return DS.Tables[0].Rows[0]["id"].ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static string GetMagacinRaspodelaIDByName(string id)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM magacin_raspodela WHERE naziv = ('" + id + "')";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);


                return DS.Tables[0].Rows[0]["id"].ToString();

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return null;
            }
        }

        public static Class.MagacinRaspodela GetMagacinRaspodela(string id)
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM magacin_raspodela WHERE id=(" + id + ")";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Class.MagacinRaspodela magacin = new Class.MagacinRaspodela()
                {
                    Naziv = DS.Tables[0].Rows[0]["naziv"].ToString(),
                    Gradiliste = DS.Tables[0].Rows[0]["gradiliste"].ToString(),
                    Kolicina = int.Parse(DS.Tables[0].Rows[0]["kolicina"].ToString())
                };
                //(int)DS.Tables[0].Rows[0]["dostupno"]
                return magacin;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }



        public static List<Delatnosti> GetAllDelatnosti()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM radnik_delatnost";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Delatnosti delatnosti = new Delatnosti();
                List<Delatnosti> delList = new List<Delatnosti>();
                foreach (DataRow dr in DS.Tables[0].Rows)
                {
                    delList.Add(new Delatnosti { Naziv = Convert.ToString(dr["naziv"]) });
                }

                return delList;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static List<TipObjekta> GetAllTipObjekta()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM tip_objekta";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                TipObjekta tipObjekta  = new TipObjekta();
                List<TipObjekta> tipObjList = new List<TipObjekta>();
                foreach (DataRow dr in DS.Tables[0].Rows)
                {
                    tipObjList.Add(new TipObjekta { Naziv = Convert.ToString(dr["naziv"]) });
                }

                return tipObjList;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static List<Gradilista> GetAllGradilista()
        {
           //POTREBNO DODATI UCITAVANJE I OSTALIH POLJA

            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM gradilista";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Gradilista gradilista = new Gradilista();
                List<Gradilista> gradList = new List<Gradilista>();
                foreach (DataRow dr in DS.Tables[0].Rows)
                {
                    gradList.Add(new Gradilista { Naziv = Convert.ToString(dr["naziv"]) });
                }

                return gradList;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static List<Projekti> GetAllProjketi()
        {
            //POTREBNO DODATI UCITAVANJE I OSTALIH POLJA

            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=db.db;Version=3;");
                connection.Open();
                SQLiteCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM projketi";
                SQLiteDataAdapter DB = new SQLiteDataAdapter(command.CommandText, connection);
                connection.Close();

                DataSet DS = new DataSet();
                DB.Fill(DS);

                Projekti gradilista = new Projekti();
                List<Projekti> gradList = new List<Projekti>();
                foreach (DataRow dr in DS.Tables[0].Rows)
                {
                    gradList.Add(new Projekti { Naziv = Convert.ToString(dr["naziv"]) });
                }

                return gradList;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static bool CheckRadnikExist(Radnik radnik)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {
              
                String query = "select count(1) from radnici where jmbg='" + radnik.JMBG + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);

                cmd.CommandType = CommandType.Text;
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }
        }

        public static bool CheckDelatnostExist(Delatnosti delatnosti)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                String query = "select count(1) from radnik_delatnost where naziv='" + delatnosti.Naziv + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);

                cmd.CommandType = CommandType.Text;
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }
        }

        public static bool CheckTipObjektaExist(TipObjekta tipObjekta)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=db.db;Version=3;");
            if (m_dbConnection.State == ConnectionState.Closed)
                m_dbConnection.Open();

            try
            {

                String query = "select count(1) from tip_objekta where naziv='" + tipObjekta.Naziv + "'";
                SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);

                cmd.CommandType = CommandType.Text;
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                m_dbConnection.Close();
            }
        }
    }
}
