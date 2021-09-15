@echo on

rd /s /q "./.vs"
rd /s /q "./Binaries"
RMDIR /s /q "./Build"
RMDIR /s /q "./DerivedDataCache"
RMDIR /s /q "./Intermediate"
RMDIR /s /q "./Saved"
del *.sln -fq

@echo Cleaned Out All Boggarts, Grindylows, and Hinkypunks!