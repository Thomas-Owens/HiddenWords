# HiddenWords
A project attempting to use a lossless picture format to hide data (text) within a picture.
This project was abandoned for the better part of a year, a potiential partner dropped interest early on, life got busy. I'm ressurecting it because working customer service actually just sucks. 

# Goals:
1. Produce a functional Text to ASCII converter. This has been done before, and might be done through a library instead. 
2. Aquire bit-level information for an image, likely using the C# itmap class, pending a review of functionality. 
3. encode ASCII to the color data for pixels, likely only changing the least valuable bit of a fixed position to minimize impact to the picture itself. 
4. Save this picture in a lossless format. 
5. Be able to read in such a picture, and decode the information stored. 

# Future goals:
1. Wider image format support
2. input via text document
3. GIMP extension
4. other releases
5. Respectable runtimes
6. encryption built in. because excess is funny. 
