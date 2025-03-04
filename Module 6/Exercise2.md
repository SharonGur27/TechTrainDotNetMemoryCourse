# Using PerfView to Find Memory Issues in WilliWonkaChocolateFactory (Alternatively, use project MemoryLeak in Module 5.sln)

## Step 1: Download and Install 
1. Go to the [PerfView GitHub Releases page](https://github.com/microsoft/perfview/releases).
2. Download the latest version of PerfView.
3. Extract the downloaded zip file to a preferred location on your machine.

## Step 2: Build the Project & Run it
1. Open Visual Studio 2022.
2. Load the `Module6` solution.
3. Make sure 'WilliWonkaChocolateFactory' is set as start up project.
4. Build the project by selecting __Build > Build Solution__ or pressing `Ctrl+Shift+B`.
5. Run the application.

## Step 3: Take the First Snapshot
1. Open PerfView by running `PerfView.exe`.
2. In PerfView, go to the __Memory__ menu and select __Take Heap Snapshot__.
3. In the dialog that opens, choose your process and double-click it.

## Step 4: Take the Second Snapshot
1. Wait a few minutes, check in the Task Manager that the memory is growing.
2. In PerfView, go to the __Memory__ menu and select __Take Heap Snapshot__.
3. In the dialog that opens, choose your process and double-click it.

## Step 5: Compare the Snapshots
2. In PerfView, go to the first gcdump file and open it.
3. Choose __Heap Stacks__ and open it.
4. Go to the second gcdump file and open it.
5. Choose __Heap Stacks__ and open it.
6. Go to the window with the second gcdump file and choose __Diff__.

## Step 6: Analyze the Differences
1. Look for differences in large objects or a high number of allocations that might indicate memory leaks or inefficient memory usage.
2. Pay attention to objects that are not being garbage collected, which might indicate references that are not being released properly.
3. Identify any improvements or regressions in memory usage between the two snapshots.

## This Project Contains the following Memory Leak Types
1. **Cache Leak**: Objects are stored and not deleted.
2. **Unmanaged Resource Leak**: Allocating unmanaged memory without freeing it.
