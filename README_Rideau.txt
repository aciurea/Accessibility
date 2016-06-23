
To publish FormBuilders
=========================>>>>>>>>>>>>>>------------<<<<<<<<<<<<<<<<

if you want to test your modification, you will need to update the version of AssemblyInfo of each project in the FormBuilder solution (all of them needs to be incremented)

i think you should set all the versions to "3.0.0.0", for both AssemblyVersion and AssemblyFileVersion

you should also change all the nuspec files from all project to make sure you can publish the nugget as a prerelease.

for example, each nuspec file should have this :
<version>$version$</version>
replace by
<version>$version$-alin1</version>

then you can publish the nugget with PublishNugetPackages.bat


after publishing, you need to update all the formbuilders nugget in both Social and SA with the prerelease you just did



To debug RecognitionCreatedMessageHandler
=========================>>>>>>>>>>>>>>------------<<<<<<<<<<<<<<<<

if you want to debug from recognitionCreatedMessageHandler, in enbridge.xml, you will need to set those to false:
    <property name="UseQueueToCreateCertificateBatch" value="true"></property>
    <property name="UseQueueToReleaseCertificateBatch" value="true"></property>
    <property name="UseQueueToValidateCertificateBatch" value="true"></property>

then find the right webqueuedprocess_id with processtypename "RecognitionCreatedMessageHandler" and use it to debug


=========================>>>>>>>>>>>>>>------------<<<<<<<<<<<<<<<<
use sa_rca
select top 100 * from WebQueuedProcesses 
--where WebQueuedProcess_id=7586940
order by 1 desc
