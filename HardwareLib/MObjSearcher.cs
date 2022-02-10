using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HardwareLib
{

    public class MObjSearcher
    {
        string select_ = "select * from";
        string NULL = "<NULL>";

        ManagementObjectSearcher searcher;
        ManagementObjectCollection MOCollection;

        public List<DMObject> dMObjects = new List<DMObject>();
        public MObjSearcher()
        {
            searcher = new ManagementObjectSearcher();


        }
        public void Find(HIKeys hIKeys )
        {
            
            searcher = new ManagementObjectSearcher(select_ + " " + GHIKeys.GetKey(hIKeys));
            MOCollection = searcher.Get();
        }
        /// <summary>
        /// add items List<DMObject> dMObjects
        /// </summary>
        public void GetInformations()
        {
            dMObjects.Clear();
            foreach (ManagementObject item in this.MOCollection)
            {
                foreach (PropertyData pdata in item.Properties)
                {
                    string name_ = pdata.Name;
                    string value_ = string.Empty;
                    string type_value_ = string.Empty;
                    if (pdata.Value != null && pdata.Value.ToString() != string.Empty)
                    {
                        Type type_value = pdata.Value.GetType();
                        type_value_ = type_value.FullName;
                        switch (type_value_)
                        {
                            case "System.String[]":
                                value_ = string.Join(" " , pdata.Value);
                                break;
                            case "System.String":
                                value_ = pdata.Value.ToString();

                                break;
                            case "System.UInt32":
                                value_ = pdata.Value.ToString();
                                break;
                            default:
                                
                                break;
                        }
                    }
                    else
                    {
                        value_ = NULL;
                        type_value_ = NULL;
                    }


                    DMObject obj_ = new DMObject()
                    {
                        Name = name_,
                        Value = value_,
                        Type = type_value_,
                    };

                    dMObjects.Add(obj_);
                }

            }
        }
    }
}
