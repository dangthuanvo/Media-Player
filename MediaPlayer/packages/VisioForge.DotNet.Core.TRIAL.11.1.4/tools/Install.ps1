# param($installPath, $toolsPath, $package, $project)

# try
# {
# Write-Output "installPath: $installPath"
# Write-Output "toolsPath: $toolsPath"
# Write-Output "package: $package"
# Write-Output "project: $project"
# }
# catch
# {
#     " $_" | Add-Content $ErrorLog
# }

Add-Type -AssemblyName System.Windows.Forms

#[System.Windows.Forms.MessageBox]::Show('x1')

Function Test-MsiProductInstalled {
    param([string]$ProductCode)

    $MsiInstance = @"
    using System.Runtime.InteropServices;
    using System;
    public static class Msi
    {
	    [DllImport("msi.dll", SetLastError = true)]
	    public static extern Int32 MsiQueryProductState(string szProduct);
    }
"@

    Add-Type -TypeDefinition $MsiInstance -Language CSharp

    #[Msi]::MsiQueryProductState($ProductCode)

    if ([Msi]::MsiQueryProductState($ProductCode) -eq 5) {  
        return $true
    }
    else {
        return $false
    }
}

#[System.Windows.Forms.MessageBox]::Show('x2')

# Get the ID and security principal of the current user account
$myWindowsID = [System.Security.Principal.WindowsIdentity]::GetCurrent();
$myWindowsPrincipal = New-Object System.Security.Principal.WindowsPrincipal($myWindowsID);

# Get the security principal for the administrator role
$adminRole = [System.Security.Principal.WindowsBuiltInRole]::Administrator;

# Check to see if we are currently running as an administrator
if ($myWindowsPrincipal.IsInRole($adminRole)) {
    # We are running as an administrator, so change the title and background colour to indicate this
    $Host.UI.RawUI.WindowTitle = $myInvocation.MyCommand.Definition + "(Elevated)";
    $Host.UI.RawUI.BackgroundColor = "DarkBlue";
   # Clear-Host;
}
else {
    # We are not running as an administrator, so relaunch as administrator

    # Create a new process object that starts PowerShell
    $newProcess = New-Object System.Diagnostics.ProcessStartInfo "PowerShell";

    # Specify the current script path and name as a parameter with added scope and support for scripts with spaces in it's path
    $newProcess.Arguments = "-ExecutionPolicy ByPass -noexit & '" + $script:MyInvocation.MyCommand.Path + "'"

    # Indicate that the process should be elevated
    $newProcess.Verb = "runas";

    # Start the new process
    [System.Diagnostics.Process]::Start($newProcess);

    # Exit from the current, unelevated, process
    Exit;
}

# Run your code that needs to be elevated here...

#[System.Windows.Forms.MessageBox]::Show('E1')

$toolsPath = split-path -parent $MyInvocation.MyCommand.Definition
#[System.Windows.Forms.MessageBox]::Show($toolsPath)

$installPath = split-path -parent $toolsPath
#[System.Windows.Forms.MessageBox]::Show($installPath)

Write-Output "toolsPath: $toolsPath"
Write-Output "installPath: $installPath"

# Update system PATH
$pathx = $toolsPath + '\Filters;'
$pathx += $toolsPath + '\FFMPEG;'
$pathx += $toolsPath + '\LAV\x64;'
$pathx += $toolsPath + '\LAV\x86;'

$ErrorLog = $toolsPath + "\InstallLog.txt"

[Environment]::SetEnvironmentVariable("Path", $env:Path + ";" + $pathx, [EnvironmentVariableTarget]::Machine)

# Install VC++ redist
$argx = "/q /norestart"

# $vc10sp1x86id = "{F0C3E5D1-1ADE-321E-8167-68EF0DE699A5}"
# $vc10sp1x64id = "{1D8E6291-B0D5-35EC-8441-6616F567A0F7}"

# if (Test-MsiProductInstalled($vc10sp1x86id) == $false) {
#     $CMD = $toolsPath + '\vcredist_x86.exe' 
#     & $CMD $argx | Out-Null
# }

# if (Test-MsiProductInstalled($vc10sp1x64id) == $false) {
#     $CMD = $toolsPath + '\vcredist_x64.exe'
#     & $CMD $argx | Out-Null
# }

$vc10sp1x86file = $env:WINDIR + "\system32\msvcp100.dll"
$vc10sp1x64file = $env:WINDIR + "\SysWOW64\msvcp100.dll"

    #$ErrorMessage = $_.Exception.Message
    #$FailedItem = $_.Exception.ItemName

Try
{ 
#if (![System.IO.File]::Exists($vc10sp1x86file)) {
    $CMD = $toolsPath + '\vcredist_x86.exe' 
    & $CMD $argx | Out-Null
#}
}
Catch
{
    " $_" | Add-Content $ErrorLog
} 

Try
{ 
#if (![System.IO.File]::Exists($vc10sp1x64file)) {
    $CMD = $toolsPath + '\vcredist_x64.exe'
    & $CMD $argx | Out-Null
#}
}
Catch
{
    " $_" | Add-Content $ErrorLog
} 

# Run filters registration
Try
{ 
$CMD = $toolsPath + '\Filters\reg_special.exe'
& $CMD 
}
Catch
{
    " $_" | Add-Content $ErrorLog
} 

Try
{ 
$CMD = $toolsPath + '\FFMPEG\reg_special.exe'
& $CMD 
}
Catch
{
    " $_" | Add-Content $ErrorLog
} 

Try
{ 
$CMD = $toolsPath + '\LAV\x64\reg_special.exe'
& $CMD 
}
Catch
{
    " $_" | Add-Content $ErrorLog
} 

Try
{ 
$CMD = $toolsPath + '\LAV\x86\reg_special.exe'
& $CMD 
}
Catch
{
    " $_" | Add-Content $ErrorLog
} 

# Install into GAC
# Try
# { 
# [System.Reflection.Assembly]::Load("System.EnterpriseServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")            
# $publish = New-Object System.EnterpriseServices.Internal.Publish   
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.Types.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.MediaFramework.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.Shared.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.Tools.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.DirectX.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.Controls.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.Controls.UI.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

# Try
# { 
# $argx = $installPath + '\lib\net45\VisioForge.Controls.UI.Dialogs.dll'
# $publish.GacInstall($argx)      
# }
# Catch
# {
#     " $_" | Add-Content $ErrorLog
# } 

Read-Host -Prompt "Press Enter to exit"