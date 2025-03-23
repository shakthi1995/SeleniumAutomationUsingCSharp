using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class PrintHtmlTable
    {
        public void PrintWebTables(IWebDriver driver, IWebElement table)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", table);

            IList<IWebElement> rows = table.FindElements(By.TagName("tr"));

            for(int i=0; i<rows.Count; i++)
            {
                IList<IWebElement> cols = rows[i].FindElements(By.TagName("td"));

                if(cols.Count == 0)
                {
                    cols = rows[i].FindElements(By.TagName("th"));
                }

                foreach(IWebElement col in cols)
                {
                    Console.Write(col.Text + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
