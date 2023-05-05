using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO
{
    /*!
	\brief Класс - продукция
	

	Класс, описывающий информацию о ТМЦ
*/
    public class product
    {
        public int Id { get; set; }
        public string? kmat { get; set; }
        public string? nmat { get; set; }
        public double krt { get; set; }
        public int len { get; set; }
    }
}
