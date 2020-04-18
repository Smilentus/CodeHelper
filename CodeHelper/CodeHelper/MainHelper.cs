using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.IO;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows;

namespace CodeHelper
{
    public static class MainHelper
    {
        private static string pathToSaveNoteBodies = @"notes\helper_note_";

        public static int openedIndex = -1;

        public static List<CodeNote> data = new List<CodeNote>();

        public static JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };

        public static void CreateNote()
        {
            data.Add(new CodeNote() { noteName = "", noteDescr = "", noteOptions = new Dictionary<string, string>() });
        }

        public static void CreateAndOpenNote()
        {
            data.Add(new CodeNote() { noteName = "", noteDescr = "", noteOptions = new Dictionary<string, string>() });
            OpenNote(data.Count - 1);
        }

        public static void OpenNote(int index)
        {
            openedIndex = index;
        }

        public static Dictionary<string, string> GetOptionsFromActiveNode()
        {
            return data[openedIndex].GetOptions();
        }

        public static void AddOptionsToActiveNote(string key, string value)
        {
            data[openedIndex].SetOptions(key, value);
        }

        public static void SaveData()
        {
            string json = JsonSerializer.Serialize<List<CodeNote>>(data, options);
            File.WriteAllText("data.json", json, Encoding.UTF8);
        }
        
        public static void SaveNoteBody(RichTextBox rtb)
        {
            TextRange range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            FileStream fs = new FileStream(pathToSaveNoteBodies + openedIndex, FileMode.OpenOrCreate);
            range.Save(fs, DataFormats.XamlPackage);
            fs.Close();
        }
        
        public static void LoadData()
        {
            if (File.Exists("data.json"))
            {
                string json = File.ReadAllText("data.json", Encoding.UTF8);
                data = JsonSerializer.Deserialize<List<CodeNote>>(json);
            }
        }

        public static RichTextBox LoadNoteBody(RichTextBox rtb)
        {
            TextRange range;
            FileStream fs;
            if (File.Exists(pathToSaveNoteBodies + openedIndex))
            {
                range = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
                fs = new FileStream(pathToSaveNoteBodies + openedIndex, FileMode.Open);
                range.Load(fs, DataFormats.XamlPackage);
                fs.Close();
            }
            return rtb;
        }

        public static void RemoveNoteBody()
        {
            File.Delete(pathToSaveNoteBodies + openedIndex);
        }
    }
}
