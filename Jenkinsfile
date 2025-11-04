pipeline {
    agent any

    options {
        quietPeriod(60)
    }
    
    stages {
        stage('Checkout') {
            steps {
                script {
                    if (env.BRANCH_NAME) {
                        params.BRANCH = env.BRANCH_NAME 
                    }
                    echo "Récupération de la branche: ${params.BRANCH}"
                    git url: "https://github.com/picsouman/TestEFCoreEtEF6.git",
                        branch: "${params.BRANCH}"
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
