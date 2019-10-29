using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
using Toxy;
using Toxy.Parsers;*/

namespace Hackathon_2019.Classes
{
	/// <summary>
	/// Class for processing Pdf files. Using convertor Toxy to for convertion from pdf to plaine text.
	/// </summary>
	class ClassPDF2Text
	{
		/*!!!!Toxy dowload from NuGet Packages... - support only .NET Framework!!!*/
		/*
		/// <summary>
		/// Toxy parser context.
		/// </summary>
		private ParserContext parserContext = null;
		/// <summary>
		/// Toxy pdf parser.
		/// </summary>
		private PDFDocumentParser pDFDocumentParser = null;
		/// <summary>
		/// Toxy document where is stored pdf file.
		/// </summary>
		private ToxyDocument Document = null;
		/// <summary>
		/// String containing path for pdf file.
		/// </summary>
		public string Path { get; private set; } = string.Empty;
		/// <summary>
		/// String array of processed data from pdf file. Contains paragraph strings from pdf file.
		/// </summary>
		public string[] Values { get; private set; } = null;


		/// <summary>
		/// Class for processing Pdf files. Using convertor Toxy to for convertion from pdf to plaine text.
		/// </summary>
		/// <param name="path">Path for pdf file to process.</param>
		public ClassPdfToPlaneText(string path)
		{
			try
			{
				Path = path;
				parserContext = new ParserContext(path);
				pDFDocumentParser = new PDFDocumentParser(parserContext);
			}
			catch
			{
				Dispose();
			}
		}
		/// <summary>
		/// Process PDF file (Document) data to string array (ProcessData). Return -1 = failed | 0 = not valid data | 1 = process sucessfull .
		/// </summary>
		/// <returns></returns>
		public int ProcessPDFFile2Document()
		{
			int result = 0;
			int count = 0;
			try
			{
				if (Path != string.Empty && parserContext != null && pDFDocumentParser != null)
				{
					Document = pDFDocumentParser.Parse();
					Values = new string[Document.Paragraphs.Count];

					foreach (ToxyParagraph paragraph in Document.Paragraphs)
					{
						Values[count++] = paragraph.Text;
					}

					result = 1;
				}
			}
			catch
			{
				result = -1;
			}
			return result;
		}

		#region IDisposable Support
		private bool disposedValue = false; // To detect redundant calls
											/// <summary>
											/// Clean up any resources being used.
											/// </summary>
											/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects).
				}

				// TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
				// TODO: set large fields to null.

				disposedValue = true;
			}
		}

		// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
		// ~ClassPdfToPlaneText()
		// {
		//   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		//   Dispose(false);
		// }

		// This code added to correctly implement the disposable pattern.
		public void Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);
			// TODO: uncomment the following line if the finalizer is overridden above.
			// GC.SuppressFinalize(this);
		}
		#endregion
		*/
	}
}
