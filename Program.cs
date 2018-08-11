using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using iTextSharp.text.pdf.parser;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SearchText());
          Console.WriteLine(Profiletext(SearchText()));
            Console.ReadLine();
        }
        static string SearchText()
        {
         
            string name = @"C:\Users\DELL\Documents\Proyectopdfing\BIO-Alan-Munoz.pdf";
            PdfReader reader2 = new PdfReader(name);
            string strText = string.Empty;

            for (int page = 1; page <= reader2.NumberOfPages; page++)
            {
                ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy();
                PdfReader reader = new PdfReader(name);
                String s = PdfTextExtractor.GetTextFromPage(reader, page, its);
                s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                strText = strText + s;
                reader.Close();
            }
            return strText;
  
        }
        static string Profiletext(string profile)
        {
            profile = SearchText();
            int i = profile.IndexOf("Profile");
            int j = profile.IndexOf("Skills");
            j= j-i;
            var r = profile.Substring(i, j);
            return r;
        }
        static string Skillstext(string Skills)
        {
            Skills = SearchText();
            int i = Skills.IndexOf("Skills");
            int j = Skills.IndexOf("Technical");
            j = j - i;
            var r = Skills.Substring(i, j);
            return r;
        }
        static string Technicaltext(string technical)
        {
            technical = SearchText();
            int i = technical.IndexOf("Technical");
            int j = technical.IndexOf("Education");
            j = j - i;
            var r = technical.Substring(i, j);
            return r;
        }
        static string Educationtext(string education)
        {
            education = SearchText();
            int i = education.IndexOf("Education");
            int j = education.IndexOf("Certifications");
            j = j - i; 
            var r = education.Substring(i, j);
            return r;
        }
        static string Certificationstext(string certifications)
        {
            certifications = SearchText();
            int i = certifications.IndexOf("Certifications");
            int j = certifications.IndexOf("Experience");
            j = j - i;
            var r = certifications.Substring(i, j);
            return r;
        }
        static string Experiencetext(string experience)
        {
            experience = SearchText();
            string wordToSearch = "Experience";
            int i = experience.IndexOf("Experience");
            i = i + wordToSearch.Length;
            var r = experience.Substring(i);
            return r;
        }

    }

}
