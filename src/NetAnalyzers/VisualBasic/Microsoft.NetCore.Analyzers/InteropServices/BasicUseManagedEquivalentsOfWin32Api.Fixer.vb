' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the MIT license.  See License.txt in the project root for license information.

Imports System.Composition
Imports Microsoft.NetCore.Analyzers.InteropServices
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.CodeFixes

Namespace Microsoft.NetCore.VisualBasic.Analyzers.InteropServices
    ''' <summary>
    ''' CA2205: Use managed equivalents of win32 api
    ''' </summary>
    <ExportCodeFixProvider(LanguageNames.VisualBasic), [Shared]>
    Public NotInheritable Class BasicUseManagedEquivalentsOfWin32ApiFixer
        Inherits UseManagedEquivalentsOfWin32ApiFixer

    End Class
End Namespace
