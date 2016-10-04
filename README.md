# FileSearch
File search project involving the ability to: 

- Search the filesystem (C:\) for a given file pattern and show locations and result count
- Ensure that your design has the following features:
	* Proper loose coupling between form and application class (application does application tasks, form does only UI tasks)
	a.	Properly call Invoke when necessary
	b.	Change the cursor to busy cursor  
	c.	Offer a “cancel” button
	d.	Show a progress bar
	e.	Show a description of current task, changing as relevant
	f.	Make sure that the implementation of the task is in a threaded loop that calls a UI update about 1-10 times a second


