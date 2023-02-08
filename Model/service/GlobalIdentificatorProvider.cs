using System;
using System.Collections.Generic;
using System.IO;
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
            InitializeIdLazily();
            long idToReturn = id++;
            Save();
            return idToReturn;
        }

        private void InitializeIdLazily()
		{
            if (id == 0)
			{
                try
				{
                    id = dataFileSaver.LoadFromFile<long>(IDS_DATA_FILE_NAME);
                }
                catch (FileNotFoundException e)
				{
                    Save();
                    id = dataFileSaver.LoadFromFile<long>(IDS_DATA_FILE_NAME);
                }
            }
        }

        public void Save()
        {
            dataFileSaver.SaveToFile(id, IDS_DATA_FILE_NAME);
        }
    }
}
