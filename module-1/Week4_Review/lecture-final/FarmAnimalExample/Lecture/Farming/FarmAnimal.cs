using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : ISingable //all farm animals are Singable but not all farm animals are sellable so we put the interface on teh ones that are
    {       
        /// <summary>
        /// The farm animal's type, ie Goat, Horse,etc
        /// </summary>
        public string Type { get; }


        /// <summary>
        /// what we call it, ie Fred, George, Mary
        /// </summary>
        public string Name { get; set; }

        public List<string> Food { get; set; } = new List<string>();

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name)
        {
            this.Type = name;
        }

        /// <summary>
        /// The noise made when the farm animal makes a sound.
        /// </summary>
        /// <returns></returns>
        public virtual string MakeSoundOnce()
        {
            return "";
        }

        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public virtual string MakeSoundTwice()
        {
            return "";
        }

        public string Eat()
        {
            return "mmmm";
        }
    }
}
