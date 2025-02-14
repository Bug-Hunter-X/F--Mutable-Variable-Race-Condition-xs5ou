# F# Mutable Variable Race Condition

This repository demonstrates a potential race condition in F# code that uses mutable variables without proper synchronization. The code is a simple recursive function that increments two mutable variables. In a multi-threaded environment, multiple threads accessing and modifying these variables simultaneously can lead to unexpected and inconsistent results. 

The `bug.fs` file contains the flawed code.  The `bugSolution.fs` file provides a corrected version using `lock` for thread safety.