@echo off
echo "Connect device in FEL mode and press <Enter>"
pause

set BOARD=m3

win32\sunxi-fel.exe -p uboot %BOARD%\u-boot-sunxi-with-spl.bin write 0x42000000 %BOARD%\zImage write 0x43000000 %BOARD%\sun8i-a83t-bananapi-m3.dtb write 0x43100000 %BOARD%\boot.scr write 0x43300000 %BOARD%\initramfs.uimg
pause
