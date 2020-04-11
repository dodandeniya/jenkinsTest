pipeline {
    agent any

    stages {
        stage('Clone repo') {
            steps {
                bat "git clone https://github.com/dodandeniya/jenkinsTest.git"
            }
        }
        stage('Build') {
            steps {
                bat "msbuild -restore"
				bat "msbuild /m"
            }
        }
    }
}