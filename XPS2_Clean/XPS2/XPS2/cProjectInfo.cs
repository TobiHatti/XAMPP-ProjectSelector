using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPS2
{
    public class ProjectList
    {
        List<ProjectInfo> elements = new List<ProjectInfo>();

        public ProjectInfo this[int idx]
        {
            get => elements[idx];
            set => elements[idx] = value; 
        }

        public void Add(ProjectInfo item)
        {
            elements.Add(item);
        }

        public void RemoveAt(int index)
        {
            elements.RemoveAt(index);
        }

        public int Count
        {
            get => elements.Count;
        }

        public List<ProjectInfo> GetList
        {
            get => elements;
        }

        public void SaveToFile(string pFilePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(pFilePath))) Directory.CreateDirectory(Path.GetDirectoryName(pFilePath));

            StreamWriter sr = new StreamWriter(pFilePath);
            foreach(ProjectInfo element in elements)
            {
                sr.WriteLine(element.ToString());
            }

            sr.Close();
        }

        public void LoadFromFile(string pFilePath)
        {
            if(File.Exists(pFilePath))
            {
                StreamReader sr = new StreamReader(pFilePath);

                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    elements.Add(
                        new ProjectInfo(
                            line.Split(';')[0].TrimStart('{', '[').TrimEnd(']', '}'),
                            line.Split(';')[1].TrimStart('{', '[').TrimEnd(']', '}'),
                            line.Split(';')[2].TrimStart('{', '[').TrimEnd(']', '}')
                            ));
                }

                sr.Close();
            }
        }
    }

    public class ProjectInfo
    {
        public string ProjectName { get; set; } = "";
        public string ProjectDescription { get; set; } = "";
        public string ProjectRoot { get; set; } = "";

        public ProjectInfo(string pName, string pDescription, string pRootPath)
        {
            ProjectName = pName;
            ProjectDescription = pDescription;
            ProjectRoot = pRootPath;
        }

        public override string ToString()
        {
            return $"{{[{ProjectName}];[{ProjectDescription}];[{ProjectRoot}]}}";
        }

        public static ProjectInfo Parse(string pObjectString)
        {
            string[] objParts = pObjectString.Split(';');

            for (int i = 0; i < objParts.Length; i++) 
            {
                objParts[i] = objParts[i].TrimStart('[', '{').TrimEnd(']','}');
            }

            return new ProjectInfo(objParts[0], objParts[1], objParts[2]);
        }
    }
}
