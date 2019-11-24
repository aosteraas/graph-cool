//
//  ImagesViewController.swift
//  BagelGram
//
//  Created by Aaron Osteraas on 21/11/19.
//  Copyright © 2019 Aaron Osteraas. All rights reserved.
//

import SwiftUI
import UIKit
import Apollo


struct PageViewController : UIViewControllerRepresentable {
    var controllers: [UIViewController]
    @State public var imageData: GetImagesQuery.Data?
    var watcher: GraphQLQueryWatcher<GetImagesQuery>?
    var images: [GetImagesQuery.Data.GetImage]?
    
    func makeUIViewController(context: Context) -> UIPageViewController {
        let pageViewController = UIPageViewController(
           transitionStyle: .scroll,
           navigationOrientation: .horizontal)

        return pageViewController
    }
    
    func updateUIViewController(_ pageViewController: UIPageViewController, context: Context) {
        pageViewController.setViewControllers(
            [controllers[0]], direction: .forward, animated: true)
    }
    
//    mutating func fetchData() {
//        Server.shared.apollo.watch(query: GetImagesQuery()) { result in
//            switch result {
//            case .success(let res):
//                self.images = res.data?.getImages! as? [GetImagesQuery.Data.GetImage]
//            case .failure(let error):
//                NSLog("Error while fetching query: \(error.localizedDescription)")
//            }
//        }
//    }
}
