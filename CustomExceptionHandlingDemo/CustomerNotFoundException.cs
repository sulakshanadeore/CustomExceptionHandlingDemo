﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandlingDemo
{

	[Serializable]
	public class CustomerNotFoundException : Exception
	{
		public CustomerNotFoundException() { }
		public CustomerNotFoundException(string message) : base(message) { }
		public CustomerNotFoundException(string message, Exception inner) : base(message, inner) { }
		protected CustomerNotFoundException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
