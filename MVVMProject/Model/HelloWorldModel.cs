using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMProject.Model
{
    internal class HelloWorldModel
    {
        private List<string> repositoryData;
        public string ImportantInfo
        {
            get
            {
                return ConcatenateData(repositoryData);
            }
        }

        public HelloWorldModel()
        {
            repositoryData = GetData();
        }

        /// <summary>
        /// Simulates data retrival from a reposittory
        /// </summary>
        /// <returns> List of strings </returns>
        private List<string> GetData()
        {
            repositoryData = new List<string>()
            {
                "Hello",
                "world"
            };
            return repositoryData;
        }

        /// <summary>
        /// Concetenate the information from the list into a fully formed sentence.
        /// </summary>
        /// <returns> A string </returns>
        private string ConcatenateData(List<string> dataList)
        {
            string importantInfo = dataList.ElementAt(0) + ", " + dataList.ElementAt(1) + "!";
            return importantInfo;
        }
    }
}
