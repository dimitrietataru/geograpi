Function GetBuildVersion {
    Param (
        [string]$VersionString
    )

    $VersionString -match "(?<major>\d+)(\.(?<minor>\d+))?(\.(?<patch>\d+))?(\-(?<pre>[0-9A-Za-z\-\.]+))?(\+(?<build>\d+))?" | Out-Null
    if ($matches -eq $null) {
        return "1.0.0-build"
    }

	$Major = [uint64]$matches['major']
	$Minor = [uint64]$matches['minor']
	$Patch = [uint64]$matches['patch']
	
	$PreReleaseTag = [string]$matches['pre']
	$BuildRevision = [uint64]$matches['build']
	
	$Version = [string]$Major + '.' + [string]$Minor + '.' + [string]$Patch;
	
    if ($PreReleaseTag -ne [string]::Empty) {
        $Version = $Version + '-' + $PreReleaseTag
    }

    if ($BuildRevision -ne 0) {
        $Version = $Version + '.' + [string]$BuildRevision
    }

    return $Version
}
