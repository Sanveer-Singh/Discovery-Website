using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IRateAdvisorWeb.Utilities
{
    public class HtmlStringGenerator
    {
        /// <summary>
        /// Use this to generate subsections of formatted dynamic pages 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Picture"></param>
        /// <param name="Field1desc"></param>
        /// <param name="Field1"></param>
        /// <param name="fielddesc2"></param>
        /// <param name="field2"></param>
        /// <param name="fielddesc3"></param>
        /// <param name="field3"></param>
        /// <returns></returns>
        public static string GetDynamicReportDisplayString(string name, string Picture,string Field1desc, string Field1, string fielddesc2 , string field2, string fielddesc3, string field3 )
        {
            // create our answer 
            string display = "";
            display += "<div id='p' class='events small-thumbs' style='width:100%; padding:20px;'>";
            //div 2 open
            display += "<div class='entry clearfix'>";
            display += "<div>";
            // lets encapsulate div 3 and the image div
            // div 3 open and closed
            display += "<div class='entry-title'><h1><a href='#'>" + name + "</a></h1></div>";
            //  new div 3 open
            display += "<div class='entry-image' style='width:40%; padding: 0px 30px 20px 30px;'><a href='#'><img src='" + Picture + "' style='height:400px; background-size:cover;background-repeat:no repeat;' alt='Pet to adopt'>";
            // lets close the image div now( div 3 closed)
            display += "</div>";
            // closes the encapsulatind div that holds image and title
            display += "</div>";
            // div 5 opened
            display += "<div class='entry-c'>";
            display += "<h3 style='display: inline;'>"+Field1desc +" </h3><h4 style='display: inline;'>" + Field1 + "</h4>";// can be for employee reported 
            // div 6 opened
            display += "<div class='entry-content'>";

            // encapsulate the table in a div
            display += "<div>";
            display += "<table class='table table-bordered table-striped' style='clear: both'>";
            display += "<tbody>";
            display += "<tr>";
            display += "<td width='50%'>"+fielddesc2+"</td>";
            display += " <td width='50%'><a href='#'>" + field2 + "</a></td>";
            display += "</tr>";
            // adds a row into the table, each col covers half 
             display += "<tr>";
             display += "<td width='50%'>"+fielddesc3 +"</td>";
             display += " <td width='50%'><a href='#'>" + field3  + "</a></td>";
             display += "</tr>";
            
            // end of table 
            display += "</tbody></table>";
            display += "</div>";

      
            return display;
        }
    }   
}