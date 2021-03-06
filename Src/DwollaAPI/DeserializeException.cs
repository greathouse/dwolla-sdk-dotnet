﻿﻿//-----------------------------------------------------------------------
// <copyright file="DeserializeException.cs">
// Copyright (c) 2012 Corey Oliver
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// </copyright>
// <author>corey.jon.oliver@gmail.com</author>
//-----------------------------------------------------------------------

namespace Dwolla.API
{
    using System;

    internal class DeserializeException : DwollaAPIException
    {
        public DeserializeException(Type objectType, string objectString)
        {
            this.ObjectType = objectType;
            this.ObjectString = objectString;
        }

        public DeserializeException(Type objectType, string objectString, Exception innerException)
            : base(null, innerException)
        {
            this.ObjectType = objectType;
            this.ObjectString = objectString;
        }

        public Type ObjectType { get; private set; }

        public string ObjectString { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format(
                    "Deserialize Failed.{0}Type:{1}{0}String:{2}",
                    Environment.NewLine,
                    this.ObjectType,
                    this.ObjectString);
            }
        }
    }
}