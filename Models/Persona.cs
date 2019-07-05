using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Crud.Models
{
	public class Persona
	{
		public int ID { get; set; }
		public int NOMBRE { get; set; }
		public int GENERO { get; set; }
		public DateTime FECHA_NACIMIENTO { get; set; }
		public bool ESTADO { get; set; }
	}
}