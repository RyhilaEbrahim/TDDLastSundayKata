require "./rake-tasks/init"

$binaries_baselocation_tests = "LastSundayKata.Tests/bin"
$binaries_baselocation = "LastSundayKata/bin"
$solution = "LastSunday.sln"
$build_configuration = "Debug"

msbuild_settings = {
  :properties => {:configuration => $build_configuration},
  :targets => [:clean],
  :verbosity => :minimal,
  }

desc "Cleans the bin folder and all project bin folders"
task :clean do
    puts cyan("Cleaning all bin and test folders")
    FileUtils.rm_rf $binaries_baselocation_tests  
    FileUtils.rm_rf $binaries_baselocation  
end


desc "Builds"
task :default => [:clean,:msbuild]

desc "Builds the solution with msbuild"
msbuild :msbuild do |msb|
    puts cyan("Building #{$solution} with msbuild")
    #msb.update_attributes msbuild_settings
    msb.solution = $solution
end


