all:
	./tool/merge filelist.txt index.md
	
clean:
	rm index.md