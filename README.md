# Lab08-LINQ

## Introduction
Contained in the program is a JSON file that holds locaiton information for properties within Manhattan.

- The application reads in the file 
- Uses quires to sort the data 
- Outputs sorted data to the console

=============================================

### Sorting Outputs
- First all neighborhoods of the file are selected and out put to the console.
- Second any outputs that are empty strings are sorted out. Leaving only valid neighborhood names.
- Third all duplicate neighborhoods are consolidated so that only distinct names are displayed in the console.
- Lastly the previous sorting methods are refactored to chain off one another. 

=============================================
## Visuals

#### Shows sample of all strings associated with the sorting of the data. Shown is empty strings that will be sorted out in following steps. 
![AllOutput](https://github.com/RevYolution/Lab08-LINQ/blob/master/assets/AllHoodsOutput.PNG)

#### Shows sample of empty strings removed however, duplicate neighborhoods are still present. 
![EmptyStringsRemoved](https://github.com/RevYolution/Lab08-LINQ/blob/master/assets/NoEmptyOutput.PNG)

#### Shows all empty and duplicate data removed. 
![SingleNeighborhoods](https://github.com/RevYolution/Lab08-LINQ/blob/master/assets/NoDupsOutput.PNG)
