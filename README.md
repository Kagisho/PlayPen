# Purpose
.Net solution with projects that demonstrate concepts of software development. These will be design patterns, architectural concepts and techniques using improvements on the .Net framework and languages.

## Project list
- #### CRTP
  Demonstrate the Curiously Recurring Template Pattern. At a conceptual level, it is used when you require a base class to know about properties of a derived class.
- #### EvemtSourcing
  Solves the problem of having data store records being updated directly where the history of the record is lost. The data being updated directly is a problem of 
  scalability because the records are locked by transactions while they are updated. Event sourcing uses events to create new versions of the origin record when the record is updated. 
  Data lineage is kept and the events can be replayed if required.
  
