﻿#region Copyright 2008-2010 by Roger Knapp, Licensed under the Apache License, Version 2.0
/* Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpTest.Net.SvnPlugin
{
	partial class PasswordEntry : Form
	{
		string _forWho, _forWhere;
		public PasswordEntry(string forWho, string forWhere)
		{
			_forWho = forWho; 
			_forWhere = forWhere;
			InitializeComponent();

			if (!String.IsNullOrEmpty(forWho))
			{
				UserName.Text = forWho;
				UserName.Enabled = false;
			}
		}
	}
}
