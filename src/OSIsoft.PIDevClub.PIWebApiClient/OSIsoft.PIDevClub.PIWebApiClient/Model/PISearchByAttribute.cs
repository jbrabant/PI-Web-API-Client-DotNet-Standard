// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using System.Runtime.InteropServices;

namespace OSIsoft.PIDevClub.PIWebApiClient.Model
{

	/// <summary>
	/// PISearchByAttribute
	/// </summary>
	[DataContract]

	public class PISearchByAttribute
	{
		public PISearchByAttribute(string SearchRoot = null, string ElementTemplate = null, PIWebException WebException = null, List<PIValueQuery> ValueQueries = null)
		{
			this.SearchRoot = SearchRoot;
			this.ElementTemplate = ElementTemplate;
			this.WebException = WebException;
			this.ValueQueries = ValueQueries;
		}

		/// <summary>
		/// Gets or Sets PISearchByAttribute
		/// </summary>
		[DataMember(Name = "SearchRoot", EmitDefaultValue = false)]
		public string SearchRoot { get; set; }

		/// <summary>
		/// Gets or Sets PISearchByAttribute
		/// </summary>
		[DataMember(Name = "ElementTemplate", EmitDefaultValue = false)]
		public string ElementTemplate { get; set; }

		/// <summary>
		/// Gets or Sets PISearchByAttribute
		/// </summary>
		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

		/// <summary>
		/// Gets or Sets PISearchByAttribute
		/// </summary>
		[DataMember(Name = "ValueQueries", EmitDefaultValue = false)]
		public List<PIValueQuery> ValueQueries { get; set; }

	}
}
