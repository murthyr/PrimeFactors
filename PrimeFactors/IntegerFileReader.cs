﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    /// <summary>
    /// Interface for abstracting the reading of the integer file.
    /// </summary>
    public class IntegerFileReader : IIntegerReader
    {
        private string _path;
        private StreamReader _reader;

        /// <summary>
        /// Initializes a new instance of the IntegerFileReader class.
        /// </summary>
        /// <param name="path">The path to the file with the data to be read.</param>
        public IntegerFileReader(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Create the reader and attempt to read the next available integer.
        /// </summary>
        /// <returns>
        /// The read integer value or null if the end of file is reached.
        /// </returns>
        public int? ReadNext()
        {
            _reader = _reader ?? new StreamReader(_path);
            
            int number = 0;
            string line;
            while ((line = _reader.ReadLine()) != null)
            {
                if (Int32.TryParse(line, out number))
                {
                    return number;
                }
            }

            return null;
        }

        /// <summary>
        /// Dispose of the file resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _reader != null)
            {
                _reader.Dispose();
            }
        }
    }
}
