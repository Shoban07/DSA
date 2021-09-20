param($installPath, $toolsPath, $package, $project)

foreach ($configuration in $project.Collection.Parent.Solution.SolutionBuild.SolutionConfigurations | Where { @("Code Contracts", "Debug", "No Analysis", "Release") -contains $_.Name }) { 
	foreach ($context in $configuration.SolutionContexts | Where { $_.ProjectName -eq $project.UniqueName -and $_.ConfigurationName -ne $configuration.Name }) { 
		$project.ConfigurationManager.AddConfigurationRow($configuration.Name, $null, $false)
		$context.ConfigurationName = $configuration.Name
	} 
}

$assembly = [System.Reflection.Assembly]::LoadFile("$($toolsPath)\prjstder.exe")

$assembly.GetType("Emis.ProjectStandardisation.NugetStandardiser")::StandardiseAndGetError( { 
		if (!$project.Saved) { 
			$project.Save() 
		} 
	},
	"$($installPath)\",
	$project.FullName) |
foreach { 
	if ($_) { 
		Throw "$_"
	} 
}