# bpi-fel-mass-storage-gui4win

[![Build Status](https://travis-ci.org/OtakuNekoP/bpi-fel-mass-storage-gui4win.svg?branch=master)](https://travis-ci.org/OtakuNekoP/bpi-fel-mass-storage-gui4win)
[![Build status](https://ci.appveyor.com/api/projects/status/co914wbc2bacr02y?svg=true)](https://ci.appveyor.com/project/OtakuNekoP/bpi-fel-mass-storage-gui4win)

The GUI for bpi-fel-mass-storage with sunxi-tools in order to run under windows.

https://github.com/OtakuNekoP/bpi-fel-mass-storage

# Supported devices:

+ BPI-M2+ (H2+/H3/H5) 
+ BPI-M2Zero (H2+)
+ BPI-M3 (A83T/H8/R58) 
+ BPI-M64 (A64/R18)


# How to use:

1. Press the EFL/U-Boot button on the Banana Pi and hold, then connect to your computer with micro USB cable and release the button.
2. Install the libusbK WCID Driver for the `Unknow Device` with Zadig.
3. Run the `bpi-fel-mass-storage-gui4win.exe` and follow the instruction.
4. Waiting for the FEL loading progress.
5. Check and edit(if necessary) the partition in the `Disk Management`.
6. Flash the device with `Win32DiskImager`.
