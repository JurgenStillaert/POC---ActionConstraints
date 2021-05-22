using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;

namespace POC___ActionConstraints.Infrastructure
{
	//https://stackoverflow.com/questions/39302121/header-based-routing-in-asp-net-core
	public sealed class HttpHeaderAttribute : Attribute, IActionConstraint
	{
		public string Header { get; set; }
		public string Value { get; set; }

		public HttpHeaderAttribute(string header, string value)
		{
			Header = header;
			Value = value;
		}

		public bool Accept(ActionConstraintContext context)
		{
			if (context.RouteContext.HttpContext.Request.Headers.TryGetValue(Header, out var value))
			{
				return value[0] == Value;
			}

			return false;
		}

		public int Order => 0;
	}
}