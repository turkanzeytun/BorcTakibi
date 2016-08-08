using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CariBorcTakip.DAL.Concrates.AdoNet
{
    public class DatabaseManager
    {
        public string CreateDB(string dbName)
        {
            SqlConnection con = new SqlConnection();
            //SqlTransaction myTransaction = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                //myTransaction = con.BeginTransaction();

                string query = "use master CREATE DATABASE [" + dbName + "] ";
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.Text;
                //com.Transaction = myTransaction;
                com.ExecuteNonQuery();

                query = "use [" + dbName + "] CREATE TABLE [dbo].[ExchangeRates]([CID] [int] IDENTITY(1,1) NOT NULL, [ExchangeTypeID] [int] NULL, [RateDate] [datetime] NULL, [ExchangeBuying] [money] NULL, [ExchangeSelling] [money] NULL, [EffectiveBuying] [money] NULL, [EffectiveSelling] [money] NULL, CONSTRAINT [PK_ExchangeRates] PRIMARY KEY CLUSTERED ([CID] ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();

                query = "use [" + dbName + "] CREATE TABLE [dbo].[ExchangeTypes]([RID] [int] IDENTITY(1,1) NOT NULL, [ExchangeName] [nchar](50) NULL, [ExchangeCode] [nchar](5) NULL, CONSTRAINT [PK_ExchangeTypes] PRIMARY KEY CLUSTERED ([RID] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY]";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();

                query = "use [" + dbName + "] ALTER TABLE [dbo].[ExchangeRates]  WITH CHECK ADD  CONSTRAINT [FK_ExchangeRates_ExchangeTypes] FOREIGN KEY([ExchangeTypeID]) REFERENCES [dbo].[ExchangeTypes] ([RID])";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();

                query = "use [" + dbName + "] ALTER TABLE [dbo].[ExchangeRates] CHECK CONSTRAINT [FK_ExchangeRates_ExchangeTypes]";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();

                //myTransaction.Commit();
                return dbName + " isimli database başarı ile oluşturuldu";
            }
            catch (Exception ex)
            {
                //hata mesajı loglanacak
                //myTransaction.Rollback();
                return dbName + " isimli database oluşturulurken bir hata ile karşılaştı. Hata Detay Bilgileri: " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public string DropDB(string dbName)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "use master DROP DATABASE " + dbName;
                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                return dbName + " isimli database başarı ile SİLİNDİ";
            }
            catch (Exception ex)
            {
                //hata mesajı loglanacak
                return dbName + " isimli database silinirken bir hata ile karşılaştı. Hata Detay Bilgileri: " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public string BackUpDB(string dbName) 
        {
            SqlConnection con = new SqlConnection();
             try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "use master backup database " + dbName + " to disk ='c:\\BACKUPS\\" + dbName + ".bak' with description='Full Backup', name ='DenemeDBB'";


                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                return dbName + " isimli database başarı ile yedeklendi";
            }
            catch (Exception ex)
            {
                //hata mesajı loglanacak
                return dbName + " isimli database yedeklenirken bir hata ile karşılaştı. Hata Detay Bilgileri: " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        public string RestoreDB(string dbName)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "use master restore database " + dbName + " from disk='c:\\BACKUPS\\" + dbName + ".bak'";

                SqlCommand com = new SqlCommand(query, con);
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();

                return dbName + " isimli database başarı ile restore edildi";
            }
            catch (Exception ex)
            {
                //hata mesajı loglanacak
                return dbName + " isimli database restore edilirken bir hata ile karşılaştı. Hata Detay Bilgileri: " + ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
    }
}
