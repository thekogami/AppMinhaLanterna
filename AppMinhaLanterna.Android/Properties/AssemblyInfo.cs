using System.Reflection;
using System.Runtime.InteropServices;
using Android.App;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AppMinhaLanterna.Android")]
[assembly: AssemblyDescription("Aplicativo de lanterna desenvolvido por Felipe")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Felipe Broglio.")]
[assembly: AssemblyProduct("AppMinhaLanterna.Android")]
[assembly: AssemblyCopyright("Copyright © Felipe Broglio 2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
[assembly: AssemblyVersion("1.0.0.1")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.Flashlight)]
//[assembly: UsesPermission(Android.Manifest.Permission.Camera)]