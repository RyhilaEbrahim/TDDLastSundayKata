require "./rake-tasks/init"

#-------------------------------project settings-------------------------------


#$binaries_baselocation = "LastSundayKata/bin"
$binaries_baselocation_tests = "LastSundayKata.Tests/bin"
$solution = "LastSunday.sln"
$build_configuration = "Debug"

#______________________________________________________________________________

msbuild_settings = {
  :properties => {:configuration => $build_configuration},
  :targets => [:clean],
  :verbosity => :minimal,
  #:use => :net35  ;uncomment to use .net 3.5 - default is 4.0
}

desc "Cleans the bin folder and all project bin folders"
task :clean do
    puts cyan("Cleaning all bin and test folders")
    #FileUtils.rm_rf $binaries_baselocation
    FileUtils.rm_rf $binaries_baselocation_tests
    
end

#______________________________________________________________________________
task :default => [:clean]

#:msbuild do |msb|
#    puts cyan("Building #{$solution} with msbuild")
#    msb.update_attributes msbuild_settings
#    msb.solution = $solution
#end



