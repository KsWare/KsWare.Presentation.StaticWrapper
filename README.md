KsWare.Presentation.StaticWrapper
=================================

**[DRAFT]** Replacements for static classes.

Replacements
------------

| **Case**                       | **Solution**                                     |
|--------------------------------|--------------------------------------------------|
| Application.Current.Dispatcher | [ApplicationDispatcher](##ApplicationDispatcher) |
| Application                    | [ApplicationWrapper](##ApplicationWrapper)       |

Nuget Development Feet
----------------------

<https://ci.appveyor.com/nuget/KsWare.Presentation.StaticWrapper>

ApplicationDispatcher
---------------------

Extendable static class. \#\#\# Usage: Static:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ csharp
ApplicationDispatcher.Do.RunAsync(...)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

or if you prefer MEF:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ csharp
[Import] IApplicationDispatcher ApplicationDispatcher;
ApplicationDispatcher.Do.RunAsync(...)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Extended:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ csharp
ApplicationDispatcher.Do.AnythingCustom(...);
ApplicationDispatcher.Do.AnythingCustom();
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

ApplicationWrapper
------------------

Extendable static class. \#\#\# Usage: MEF:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ csharp
[Import] IApplication _application;
foreach(w in _application.Windows) DoAnothing(w);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Extended:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ csharp
_application.Do.AnythingCustom(...);
var v = _application.Get.AnythingCustom();
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
