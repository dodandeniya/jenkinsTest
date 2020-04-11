pipeline {
    agent any

    stages {
        stage('Clone repo') {
            steps {
				bat "IF NOT EXIST MVVMLightDemo.sln git clone https://github.com/dodandeniya/jenkinsTest.git"
                bat "git pull https://github.com/dodandeniya/jenkinsTest.git"
            }
        }
        stage('Build') {
            steps {
                bat "nuget restore"
				bat "msbuild -m"
            }
        }
    }
}