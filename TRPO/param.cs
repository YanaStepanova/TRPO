using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO
{
    /*!
	\brief Класс - параметры 
	

	Класс, храняший данные о парметрах ТМЦ
*/
    public class param
    {
        public int Id { get; set; }
        public string? kmat { get; set; }
        public string? name { get; set; }
        public string? znach { get; set; }
        public int fl { get; set; }
    }
}
