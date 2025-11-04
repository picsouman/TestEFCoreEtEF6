pipeline {
    agent any

    options {
        quietPeriod(60)
    }
    
    stages {
        stage('Checkout') {
            steps {
                script {
                    def branchName
                    if (env.BRANCH_NAME) {
                        branchName = env.BRANCH_NAME 
                    } else {
                        branchName = params.BRANCH
                    }
                    echo "Récupération de la branche: ${params.BRANCH}"
                    git url: "https://github.com/picsouman/TestEFCoreEtEF6.git",
                        branch: "${branchName}"
                }
            }
        }

        stage('Restore packages') {
            steps {  // C'était "step" au lieu de "steps"
                echo 'Restoration des packages NuGet'
                script {
                    if (isUnix()) {
                        sh 'dotnet restore'
                    } else {
                        bat 'dotnet restore'
                    }
                }
            }
        }

        stage('Build Solution') {
            steps {
                echo "Build de la solution"
                script {
                    def buildCmd = "dotnet build --configuration Release --no-restore"
                    
                    if (isUnix()) {
                        sh buildCmd
                    } else {
                        bat buildCmd
                    }
                }
            }
        }
    }
}
