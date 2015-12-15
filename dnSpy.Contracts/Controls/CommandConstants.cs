﻿/*
    Copyright (C) 2014-2015 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Windows.Controls;
using dnSpy.Contracts.Files.Tabs.TextEditor;
using dnSpy.Contracts.TreeView;

namespace dnSpy.Contracts.Controls {
	/// <summary>
	/// Constants
	/// </summary>
	public static class CommandConstants {
		/// <summary>Guid of main window</summary>
		public static readonly Guid GUID_MAINWINDOW = new Guid("6C6DF6A3-2681-4A17-B81C-7EF8ABAC845C");

		/// <summary>Guid of <see cref="ITextEditorUIContext"/> UI control</summary>
		public static readonly Guid GUID_TEXTEDITOR_UICONTEXT = new Guid("AD0DD2EF-2DCB-4079-BBC4-1D678114D66A");

		/// <summary>Guid of <see cref="ITextEditorUIContext"/>'s text editor</summary>
		public static readonly Guid GUID_TEXTEDITOR_UICONTEXT_TEXTEDITOR = new Guid("B31795A9-44FA-4DCF-BEC4-5BEE981C9C9E");

		/// <summary>Guid of <see cref="ITextEditorUIContext"/>'s text area</summary>
		public static readonly Guid GUID_TEXTEDITOR_UICONTEXT_TEXTAREA = new Guid("DF8282E5-E5B0-4A57-8C8A-3B8F7D2624AA");

		/// <summary>Guid of file <see cref="ITreeView"/></summary>
		public static readonly Guid GUID_FILE_TREEVIEW = new Guid("E0ABA20F-5CD7-4CFD-A9D4-F9F3C655DD4A");

		/// <summary>Guid of analyzer <see cref="ITreeView"/></summary>
		public static readonly Guid GUID_ANALYZER_TREEVIEW = new Guid("6C62342D-8CBE-4EC4-9E05-828DDCCFE934");

		/// <summary>Guid of search control</summary>
		public static readonly Guid GUID_SEARCH_CONTROL = new Guid("D2699C68-1A08-4522-9A2D-C5DF6002F5FC");

		/// <summary>Guid of search <see cref="ListBox"/></summary>
		public static readonly Guid GUID_SEARCH_LISTBOX = new Guid("651FC97F-A9A7-4649-97AC-FC942168E6E2");
	}
}
