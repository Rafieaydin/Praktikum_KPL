using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using test.Models;
namespace test.configs
{
    using System.IO;
    public class config
    {
        public List<Forum> configs;
        public const string filepath = @"annoy.json";
        
        public config()
        {
            try
            {
                this.LoadConfig();
            }catch (Exception ex)
            {
                this.SaveConfig();
            }

        }

        public List<Forum> LoadConfig()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            String jsonString = File.ReadAllText(path + "/Praktikum/test/test/File/" + filepath);                
            this.configs = JsonConvert.DeserializeObject<List<Forum>>(jsonString);
            return configs;
        }

        public void add(Forum forum)
        {
            List<Forum> c = this.LoadConfig();
            this.configs.Add(forum);
        }

        public void edit(Forum forum)
        {
            List<Forum> c = this.LoadConfig();
            Forum f = c.Find(x => x.id_post == forum.id_post);
            f.title = forum.title;
            f.content = forum.content;
            f.created_at = forum.created_at;
            f.comments = forum.comments;
        }

        public void delete(int id)
        {
            List<Forum> c = this.LoadConfig();
            Forum f = c.Find(x => x.id_post == id);
            c.Remove(f);
        }

        public void SaveConfig()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            String jsonString = JsonConvert.SerializeObject(configs);
            File.WriteAllText(path + "/Praktikum/test/test/File/" + filepath, jsonString);
        }

        

    }
}
