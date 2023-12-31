﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VSShellInterop = global::Microsoft.VisualStudio.Shell.Interop;
using VSShell = global::Microsoft.VisualStudio.Shell;
using DslShell = global::Microsoft.VisualStudio.Modeling.Shell;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslModeling = global::Microsoft.VisualStudio.Modeling;

namespace Company.Workshop8
{
	/// <summary>
	/// This class implements the VS package that integrates this DSL into Visual Studio.
	/// </summary>
	[VSShell::PackageRegistration(RegisterUsing = VSShell::RegistrationMethod.Assembly, UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
	[VSShell::ProvideToolWindow(typeof(Workshop8ExplorerToolWindow), MultiInstances = false, Style = VSShell::VsDockStyle.Tabbed, Orientation = VSShell::ToolWindowOrientation.Right, Window = "{3AE79031-E1BC-11D0-8F78-00A0C9110057}")]
	[VSShell::ProvideToolWindowVisibility(typeof(Workshop8ExplorerToolWindow), Constants.Workshop8EditorFactoryId)]
	[VSShell::ProvideStaticToolboxGroup("@Workshop8ToolboxTab;Company.Workshop8.Dsl.dll", "Company.Workshop8.Workshop8ToolboxTab")]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@ExampleElementToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.ExampleElementToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"CreateExampleClassF1Keyword", 
					"@ExampleElementToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 0)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@StructuralToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.StructuralToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Structural", 
					"@StructuralToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 1)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@EnablingToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.EnablingToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Enabling", 
					"@EnablingToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 2)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@ImmediateToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.ImmediateToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Immediate", 
					"@ImmediateToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 3)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@EconomicConcernToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.EconomicConcernToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"EconomicConcern", 
					"@EconomicConcernToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 4)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@SocialConcernToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.SocialConcernToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"SocialConcern", 
					"@SocialConcernToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 5)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@EnvironmentalConcernToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.EnvironmentalConcernToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"EnvironmentalConcern", 
					"@EnvironmentalConcernToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 6)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@TechnicalConcernToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.TechnicalConcernToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"TechnicalConcern", 
					"@TechnicalConcernToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 7)]
	[VSShell::ProvideStaticToolboxItem("Company.Workshop8.Workshop8ToolboxTab",
					"@RelationshipToolboxItem;Company.Workshop8.Dsl.dll", 
					"Company.Workshop8.RelationshipToolboxItem", 
					"CF_TOOLBOXITEMCONTAINER,CF_TOOLBOXITEMCONTAINER_HASH,CF_TOOLBOXITEMCONTAINER_CONTENTS", 
					"Relationship", 
					"@RelationshipToolboxBitmap;Company.Workshop8.Dsl.dll", 
					0xff00ff,
					Index = 8)]
	[VSShell::ProvideEditorFactory(typeof(Workshop8EditorFactory), 103, TrustLevel = VSShellInterop::__VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]
	[VSShell::ProvideEditorExtension(typeof(Workshop8EditorFactory), "." + Constants.DesignerFileExtension, 50)]
	[VSShell::ProvideEditorLogicalView(typeof(Workshop8EditorFactory), "{7651A702-06E5-11D1-8EBD-00A0C90F26EA}")] // Designer logical view GUID i.e. VSConstants.LOGVIEWID_Designer
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.CSharpProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::ProvideRelatedFile("." + Constants.DesignerFileExtension, Constants.DefaultDiagramExtension,
		ProjectSystem = DslShell::ProvideRelatedFileAttribute.VisualBasicProjectGuid,
		FileOptions = DslShell::RelatedFileType.FileName)]
	[DslShell::RegisterAsDslToolsEditor]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[DslShell::ProvideBindingPath]
	[DslShell::ProvideXmlEditorChooserBlockSxSWithXmlEditor(@"Workshop8", typeof(Workshop8EditorFactory))]

	internal abstract partial class Workshop8PackageBase : DslShell::AsyncModelingPackage
	{
		protected global::Company.Workshop8.Workshop8ToolboxHelper toolboxHelper;	
		
		/// <summary>
		/// Initialization method called by the package base class when this package is loaded.
		/// </summary>
		protected async override System.Threading.Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<VSShell.ServiceProgressData> progress)
		{
			await base.InitializeAsync(cancellationToken, progress);

			// Register the editor factory used to create the DSL editor.
			this.RegisterEditorFactory(new Workshop8EditorFactory(this));
			
			// Initialize the toolbox helper
			toolboxHelper = new global::Company.Workshop8.Workshop8ToolboxHelper(this);

			// Create the command set that handles menu commands provided by this package.
			Workshop8CommandSet commandSet = new Workshop8CommandSet(this);
			await commandSet.InitializeAsync(cancellationToken);
			
			// Create the command set that handles cut/copy/paste commands provided by this package.
			Workshop8ClipboardCommandSet clipboardCommandSet = new Workshop8ClipboardCommandSet(this);
			await clipboardCommandSet.InitializeAsync(cancellationToken);
			
			// Register the model explorer tool window for this DSL.
			this.AddToolWindow(typeof(Workshop8ExplorerToolWindow));

			if (cancellationToken.IsCancellationRequested)
			{
				return;
			}

			await JoinableTaskFactory.SwitchToMainThreadAsync();

			// Initialize Extension Registars
			// this is a partial method call
			this.InitializeExtensions();

			// Add dynamic toolbox items
			await this.SetupDynamicToolboxAsync(cancellationToken);
		}

		/// <summary>
		/// Partial method to initialize ExtensionRegistrars (if any) in the DslPackage
		/// </summary>
		partial void InitializeExtensions();
		
		/// <summary>
		/// Returns any dynamic tool items for the designer
		/// </summary>
		/// <remarks>The default implementation is to return the list of items from the generated toolbox helper.</remarks>
		protected override global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			try
			{
				Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
				return toolboxHelper.CreateToolboxItems();
			}
			catch (global::System.Exception e)
			{
				global::System.Diagnostics.Debug.Fail("Exception thrown during toolbox item creation.  This may result in Package Load Failure:\r\n\r\n" + e);
				throw;
			}
		}
		
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		protected override object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			Debug.Assert(toolboxHelper != null, "Toolbox helper is not initialized");
		
			// Retrieve the specified ToolboxItem from the DSL
			return toolboxHelper.GetToolboxItemData(itemId, format);
		}

		public override VSShellInterop::IVsAsyncToolWindowFactory GetAsyncToolWindowFactory(Guid toolWindowType)
		{
			if (toolWindowType == typeof(Workshop8ExplorerToolWindow).GUID)
			{
				return this;
			}

			return base.GetAsyncToolWindowFactory(toolWindowType);
		}
	}
}

//
// Package attributes which may need to change are placed on the partial class below, rather than in the main include file.
//
namespace Company.Workshop8
{
	/// <summary>
	/// Double-derived class to allow easier code customization.
	/// </summary>
	[VSShell::ProvideMenuResource("1000.ctmenu", 1)]
	[VSShell::ProvideToolboxItems(1)]
	[global::Microsoft.VisualStudio.TextTemplating.VSHost.ProvideDirectiveProcessor(typeof(global::Company.Workshop8.Workshop8DirectiveProcessor), global::Company.Workshop8.Workshop8DirectiveProcessor.Workshop8DirectiveProcessorName, "A directive processor that provides access to Workshop8 files")]
	[global::System.Runtime.InteropServices.Guid(Constants.Workshop8PackageId)]
	internal sealed partial class Workshop8Package : Workshop8PackageBase
	{
	}
}