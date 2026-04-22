# Group3-project
Week 2 Group Project: Mr Lusukama's Class


SDT621:  Software design and testing C# 

Date: 22 April  2026

WEEK 2 GROUP PROJECT : Fast Food Ordering System (GitHub Collaboration)

Group Members:
*NB!! This group has only 4 members*

Student Name and Surname

    1. Onthatile Mashego
    
    2. Michelle Muller
    
    3. Bohlokwa Moleleki
    
    4. Evan Heyman


Project Setup Process:

********************************************************************************************************************************************************
*Setting up the project in class led to some difficulties due to the following:
        - I (Onthatile) create the Github Repo BEFORE creating the C# Project File
        - Subsequently, I created the C# Project file after
        - Merging the Project File to the Github repo was the First difficulty
        -There was a lot of trial and error here but...
        - Here's how i fixed it without creating a new repo or project:
            > Step 1: Opened the Project in my Visual Studio
            > Step 2: (Clone local repo by navigating to :
                        Git (top left menu-bar) > local repositry > point or search for your project folder on your computer
            > Step 3: Link Project folder to Github repo by navigating to:
                        Git( top left menu-bar) > Manage Remotes > (scroll down) click add to paste your repo URL 
                        "https://github.com/Onthatile-CTU/Group3-project.git" leave it if it has already been added
            > Step 4: NB!! Add a .gitignore file for junk files in project folder
                    In terminal (view(top left menu-bar) > type the following:
                                                                ~ "dotnet new gitignore" 
                                                                ~ git rm -r --cached .vs
                                                                ~ git add .
                                                                ~ git commit -m "Add C# project with gitignore"
                                                                ~ git push -u origin main
            > Step 5: NB!! Pull README First, In the terminal (view(top left menu-bar) > terminal) "git pull origin main --allow-unrelated-histories"
            > Step 6:Commit project files
                    ~ Git (top left menu-bar) > commit or stash
                        NOTE: Add commit message to go along
                    ~ Click "Commit All"
            >Step 7: Push to Github

SUMMATION NOTE: so git initially would give an error message when trying to commit, push or pull siting "permissions" and that was because when you create a project file, seperately or together with github, github cannot process "junk" files like /bin, /obj, /vs. so the best option when not wanting to delete them is to place them in a gitignore file and basically github will ignore all junk files

********************************************************************************************************************************************************


In progress...

 


