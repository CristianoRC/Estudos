#!/bin/bash
sudo apt-get update &&
sudo apt-get dist-upgrade -f &&
sudo apt-get autoclean &&
sudo apt-get autoremove &&
sudo apt-get clean
