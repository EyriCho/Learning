# Azure源
#file="images_azure"
# 阿里云源
file="images_aliyuncs"

if [ -f "$file" ]
then
  echo "file found."

  while IFS='=' read -r target source
  do
    echo "${target}=${source}"
    docker pull ${source}
    docker tag ${source} ${target}
    docker rmi ${source}
  done < "$file"
else
  echo "$file not found"
fi