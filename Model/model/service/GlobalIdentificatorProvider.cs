using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos
{
    class GlobalIdentificatorProvider
    {
        private const string IDS_DATA_FILE_NAME = "ids";

        private static GlobalIdentificatorProvider instance;

        private readonly DataFileSaver dataFileSaver = new DataFileSaver();

        private long id = 0;

        private GlobalIdentificatorProvider()
        {
            id = dataFileSaver.LoadFromFile<long>(IDS_DATA_FILE_NAME);
        }

        public static GlobalIdentificatorProvider GetInstance()
        {
            if (instance == null)
            {
                instance = new GlobalIdentificatorProvider();
            }
            return instance;
        }

        public long Get()
        {
            return id++;
        }

        // TODO saving data after every change
        public void Save()
        {
            dataFileSaver.SaveToFile(id, IDS_DATA_FILE_NAME);
        }
    }
}
