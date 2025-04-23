# Using Azure Profiler to Find Memory Issues in Module 5

## Step 1: Download and Install Azure Profiler Extension
1. Go to the [AzureProfilerExtension NuGet package page](https://dev.azure.com/yourorganization/_packaging?_a=package&feed=yourfeed&package=AzureProfilerExtension&protocolType=NuGet&view=versions).
2. Click the "Download" button to download the `.nupkg` file.
3. Rename the downloaded `.nupkg` file to `.zip` extension.
4. Extract the contents of the `.zip` file.
5. Locate the `AzureProfilerExtension.exe` executable under `lib\AzureProfilerExtension`.

## Step 2: Download and Install Azure Profiler Viewer
1. Go to the https://aka.ms/azprofilerclko.
2. This will install the Azure Profiler Viewer.

## Step 3: Build and Run the MemoryLeak Project
1. Open Visual Studio 2022.
2. Load the `Module 5.sln` solution.
3. Make sure 'MemoryLeak' is set as the startup project.
4. Build the project by selecting __Build > Build Solution__ or pressing `Ctrl+Shift+B`.
5. Run the application.

## Step 4: Run Azure Profiler Extension
1. Open a command prompt or terminal.
2. Navigate to the directory where `AzureProfilerExtension.exe` is located.
3. Run the following command to start profiling:
   .\AzureProfilerExtension.exe /GroupName:TestGroupSharon /Directory:****Directory-of-your-choice**** /VerboseLog /IntervalMinutes:0 /AuxCLR
4. This will create a `*.bin` file in <Directory-of-your-choice>.

## Step 5: Analyze the Profiling Data
1. Open Azure Profiler Viewer.
2. From the menu choose __Open__ and then __Open a Single Profile File__
3. Load the `*.bin` file generated in <Directory-of-your-choice>.
4. Agree to save the file as stream.
5. Use the viewer to analyze the profiling data and identify memory issues.

## Step 6: Optimize and Fix Memory Issues
1. Based on the findings from Azure Profiler Viewer, identify the parts of your code that are causing memory issues.
2. Refactor your code to optimize memory usage
3. Re-run Azure Profiler to verify that the memory issues have been resolved.
