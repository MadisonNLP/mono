//
// Authors:
//   Rafael Mizrahi   <rafim@mainsoft.com>
//   Erez Lotan       <erezl@mainsoft.com>
//   Vladimir Krasnov <vladimirk@mainsoft.com>
//
//
// Copyright (c) 2002-2005 Mainsoft Corporation.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GHTTests.System_Web_dll.System_Web
{
	public class HttpRequest_ContentEncoding
		: GHTBaseWeb 
	{

		private void Page_Load(object sender, System.EventArgs e) 
		{
			System.Web.UI.HtmlControls.HtmlForm frm = (HtmlForm)FindControl("Form1");
			GHTTestBegin(frm);
			// ===================================
			// testing if the Browser object is set
			// ===================================
			GHTSubTestBegin("Request.ContentEncoding1");
			try
			{
				if (Request.ContentEncoding == null)
					GHTSubTestAddResult("Failed");
				else
					GHTSubTestAddResult("Success");
			}
			catch (Exception ex)
			{
				GHTSubTestAddResult("unxpected " + ex.GetType().Name + " exception was caught-" + ex.Message);
			}
            

			GHTSubTestEnd();

			// ===================================
			// testing if the objects return is from the 
			// correct type
			// ===================================
			GHTSubTestBegin("Request.ContentEncoding2");
			try
			{
				System.Text.Encoding enc = this.Request.ContentEncoding;
				GHTSubTestAddResult("success");
			}
			catch (Exception ex)
			{
				GHTSubTestAddResult("Unxpected " + ex.GetType().Name + " exception was caught-" + ex.Message);
			}
            
			GHTSubTestEnd();

			// ===================================
			// testing if the Request object returns the 
			// correct encoding
			// ===================================
			GHTSubTestBegin("Request.ContentEncoding3");
			try
			{
				System.Text.Encoding enc = this.Request.ContentEncoding;
				GHTSubTestAddResult(enc.EncodingName);
			}
			catch (Exception ex)
			{
				GHTSubTestAddResult("Unxpected " + ex.GetType().Name + " exception was caught-" + ex.Message);
			}
            
			GHTSubTestEnd();

			GHTTestEnd();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
