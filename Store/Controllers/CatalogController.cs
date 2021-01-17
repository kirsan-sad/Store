using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
using Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Store.Controllers
{
    public class CatalogController : Controller
    {

        public const string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Layouts;Integrated Security=True";

        public IActionResult Index()
        {
            DataContext db = new DataContext(connectionString);

            var applePhone = db.GetTable<Phones>();
            var query = applePhone.Where(a => a.Brand == "apple");

            ViewBag.Content = query;
            return View();
        }

        public IActionResult Phones()
        {
            var listPhones = new List<Phones>();

            string sqlExpression = $"SELECT * FROM Mobile_Phone";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var phone = new Phones {
                            Id = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Price = reader.GetInt32(3),
                            System = reader.GetString(4) 
                        };

                        listPhones.Add(phone);
                    }
                }
            }

            ViewBag.Content = listPhones;
            return View();
        }

        public IActionResult Cameras()
        {
            var listCameras = new List<Cameras>();

            string sqlExpression = $"SELECT * FROM Camera";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var camera = new Cameras
                        {
                            Id = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Price = reader.GetInt32(3),
                        };

                        listCameras.Add(camera);
                    }
                }
            }
            ViewBag.Content = listCameras;
            return View();
        }

        public IActionResult Notebooks()
        {
            var listNotebooks = new List<Notebooks>();

            string sqlExpression = $"SELECT * FROM Notebook";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var notebook = new Notebooks
                        {
                            Id = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Price = reader.GetInt32(3),
                            System = reader.GetString(4)
                        };

                        listNotebooks.Add(notebook);
                    }
                }
            }

            ViewBag.Content = listNotebooks;
            return View();
        }

        public IActionResult Headphoneses()
        {
            var listHeadphoneses = new List<Headphoneses>();

            string sqlExpression = $"SELECT * FROM Headphones";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var headphones = new Headphoneses
                        {
                            Id = reader.GetInt32(0),
                            Brand = reader.GetString(1),
                            Model = reader.GetString(2),
                            Price = reader.GetInt32(3),
                        };

                        listHeadphoneses.Add(headphones);
                    }
                }
            }

            ViewBag.Content = listHeadphoneses;
            return View();
        }
    }
}