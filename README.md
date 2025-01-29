# Incorrect Swap Function for Mutable Variables in F#

This repository demonstrates a common error when working with mutable variables in F#. The `swap` function attempts to swap the values of two mutable variables, but it doesn't achieve the desired result due to how F#'s mutable variable assignment works.  The provided solution fixes this issue.

## Bug Description

The initial `swap` function appears to correctly swap the values. However, due to how the function parameters are handled with mutability, the values aren't swapped outside the function's scope. 

## Solution

The corrected solution uses tuples to return the swapped values, solving the issue.  Passing variables by reference is not applicable in a direct manner in F# as it is in some other languages.