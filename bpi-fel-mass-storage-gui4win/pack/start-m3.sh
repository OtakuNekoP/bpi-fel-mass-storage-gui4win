sudo sunxi-fel -v -p \
	uboot u-boot-sunxi-with-spl.bin \
	write 0x42000000 zImage \
	write 0x43000000 sun8i-a83t-bananapi-m3.dtb \
	write 0x43100000 boot.scr \
	write 0x43300000 initramfs.uimg
