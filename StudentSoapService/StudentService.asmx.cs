using StudentSoapService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace StudentSoapService
{
    /// <summary>
    /// Este es un servicio soap creado para la busqueda de estudiantes de un Instituto X
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StudentService : System.Web.Services.WebService
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Juan", Lastname = "Olivo", Age = 19, PhoneNumber = "8097203456", Adress = "Los Mameyes, Santo Domingo", Gender = "M" },
            new Student { Id = 2, Name = "Pedro", Lastname = "Gutierrez", Age = 20, PhoneNumber = "8294052930", Adress = "Ensanche Espaillat, Santo Domingo", Gender = "M"},
            new Student { Id = 3, Name = "Maria", Lastname= "Peña", Age = 18, PhoneNumber = "8092739383", Adress = "Cancino, Santo Domingo", Gender = "F"},
            new Student { Id = 4, Name = "Magali", Lastname = "Norberto", Age = 23, PhoneNumber = "8495662530", Adress = "Los Frailes, Santo Domingo", Gender = "F"},
            new Student{ Id = 5,  Name = "Antonio", Lastname = "Camacho", Age = 24, PhoneNumber = "8293285066", Adress = "San Isidro, Santo Domingo", Gender = "M"}
             
        };
        

        [WebMethod]
        public Student GetStudentByName(String Name)
        {
            return students.Find(x => x.Name == Name);
        }

        [WebMethod]
        public Student GetStudentById(int Id)
        {
            return students.Find(x => x.Id == Id);
        }

    }
}